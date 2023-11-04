using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SISVIANSA_ITI_2023.GUI;
using SISVIANSA_ITI_2023.Persistencia;

namespace SISVIANSA_ITI_2023.Logica
{
    public class Cliente
    {
        // Ambos
        private byte rol;
        private string calle, esq, tipo, nombre, tipoDoc;
        private int id, nroPuerta;
        private bool activo, autorizado;
        private long doc;
        private List<string> mails;
        private List<int?> tels;
        private List<Cliente> listaClientes;
        private ClientesBD clientesBD;
        private Cliente cliente;

        // Comun
        private string pNom, sNom, pApe, sApe;

        


        // --------------- CONSTRUCTOR --------------------
        public Cliente(byte rol)
        {
            this.rol = rol;
            clientesBD = new ClientesBD(rol);
        }


        // ------------------- GETTERS Y SETTERS -------------------
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Calle
        {
            get { return calle; }
            set { calle = value; }
        }

        public string Esq
        {
            get { return esq; }
            set { esq = value; }
        }

        public int NroPuerta
        {
            get { return nroPuerta; }
            set { nroPuerta = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string PNom
        {
            get { return pNom; }
            set { pNom = value; }
        }

        public string SNom
        {
            get { return sNom; }
            set { sNom = value; }
        }

        public string PApe
        {
            get { return pApe; }
            set { pApe = value; }
        }

        public string SApe
        {
            get { return sApe; }
            set { sApe = value; }
        }

        public string TipoDoc
        {
            get { return tipoDoc; }
            set { tipoDoc = value; }
        }

        public long Doc
        {
            get { return doc; }
            set { doc = value; }
        }

        public bool Activo
        {
            get { return activo; }
            set { activo = value; }
        }

        public bool Autorizado
        {
            get { return autorizado; }
            set { autorizado = value; }
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public List<string> Mails
        {
            get { return mails; }
            set { mails = value; }
        }

        public List<int?> Tels
        {
            get { return tels; }
            set { tels = value; }
        }

        public string direccion()
        {
            string dir = Calle + " " + NroPuerta + ". Esq. " + Esq + ".";
            return dir;
        }

        // --------------------------- VALIDACION DE DATOS ------------------------------
        public bool verificarDocumentos(string tipoDoc, string strNumDoc)
        {
            try
            {
                long numDoc = Int64.Parse(strNumDoc);
                bool ci = tipoDoc.Equals("CI") && numDoc.ToString().Length == 8;
                bool dni = tipoDoc.Equals("DNI") && numDoc.ToString().Length == 12;
                bool rut = tipoDoc.Equals("RUT") && numDoc.ToString().Length == 12;

                return ci || dni || rut;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool verificarCampoNoVacio(string cadena)
        {
            return !String.IsNullOrEmpty(cadena);
        }

        public bool verificarCampoNumerico(string numero)
        {
            try
            {
                Int32.Parse(numero);
                return true;
            } catch (Exception ex)
            {
                return false;
            }
        }

        public bool verificarTelefono(string tel, bool opcional)
        {
            bool esNumero = verificarCampoNumerico(tel);
            bool ochoDigitos = tel.Length == 8;
            return (esNumero && ochoDigitos) || opcional;
        }

        public bool verificarMail(string mail, bool opcional)
        {
            bool usuarioCorrecto = false, dominioCorrecto = false;
            try
            {
                string usuario = mail.Split('@')[0];
                string dominio = mail.Split('@')[1];

                if (usuario.Length >= 6 && usuario.Length <= 30)
                    usuarioCorrecto = true;

                if (dominio.Length >= 4 && dominio.Length <= 255)
                    dominioCorrecto = true;
            }
            catch (Exception ex)
            {
                usuarioCorrecto = false;
                dominioCorrecto = false;
            }

            return (usuarioCorrecto && dominioCorrecto) || opcional;
        }

        public bool verificarNumeroDocParaBusqueda(string strNumDoc)
        {
            try
            {
                Convert.ToInt32(strNumDoc);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        // ---------------------------- METODOS AUXILIARES --------------------------------
        public void cargarTelefonos()
        {
            Tels = clientesBD.buscarTelefonosDeCliente(Id);
        }

        public void cargarMails()
        {
            Mails = clientesBD.buscarMailsDeCliente(Id);
        }

        public Cliente cargarDatosDeCliente(int id)
        {
            cliente = new Cliente(rol);

            cliente = clientesBD.buscarClientesPorId(id);
            cliente.cargarTelefonos();
            cliente.cargarMails();

            return cliente;
        }


        // --------------------------------- ABM --------------------------------------
        public bool ingresar()
        {
            return true;
        }

        public bool modificar()
        {
            return true;
        }


        // ------------------------------- CONSULTAS -----------------------------------
        public void crearVistaClientes()
        {
            clientesBD.crearVistaClientes();
        }

        // Busqueda
        public List<Cliente> realizarBusquedaFiltrada(string colFiltro, string valFiltro)
        {
            listaClientes = new List<Cliente>();

            if (colFiltro.Equals("todo"))
                listaClientes = buscarTodosLosClientes();

            else if (colFiltro.Equals("id"))
                listaClientes = buscarClientesPorId(valFiltro);

            else if (colFiltro.Equals("nro_doc"))
                listaClientes = buscarClientesPorNroDoc(valFiltro);

            else if (colFiltro.Equals("nombre"))
                listaClientes = buscarClientesPorNombre(valFiltro);

            else if (colFiltro.Equals("tipo"))
                listaClientes = buscarClientesPorTipo(valFiltro);

            else if (colFiltro.Equals("activo"))
                listaClientes = buscarClientesActivosOInactivos(true);

            else if (colFiltro.Equals("inactivo"))
                listaClientes = buscarClientesActivosOInactivos(false);

            else if (colFiltro.Equals("autorizado"))
                listaClientes = buscarClientesAutorizadosONoAutorizados(true);

            else if (colFiltro.Equals("no autorizado"))
                listaClientes = buscarClientesAutorizadosONoAutorizados(false);

            else if (colFiltro.Equals("activo y autorizado"))
                listaClientes = buscarClientesActivosYAutorizados();

            return listaClientes;
        }

        private List<Cliente> buscarClientesPorId(string num)
        {
            int id = Convert.ToInt32(num);
            listaClientes.Clear();
            listaClientes.Add(clientesBD.buscarClientesPorId(id));

            foreach (Cliente cliente in listaClientes)
            {
                cliente.cargarTelefonos();
                cliente.cargarMails();
            }

            return listaClientes;
        }

        private List<Cliente> buscarClientesPorNroDoc(string nroDoc)
        {
            long nDoc = Convert.ToInt64(nroDoc);
            listaClientes = clientesBD.buscarClientesPorNroDoc(nDoc);

            foreach (Cliente cliente in listaClientes)
            {
                cliente.cargarTelefonos();
                cliente.cargarMails();
            }

            return listaClientes;
        }

        private List<Cliente> buscarTodosLosClientes()
        {
            listaClientes = clientesBD.buscarTodosLosClientes();

            foreach (Cliente cliente in listaClientes)
            {
                cliente.cargarTelefonos();
                cliente.cargarMails();
            }

            return listaClientes;
        }

        private List<Cliente> buscarClientesPorNombre(string nombre)
        {
            listaClientes = clientesBD.buscarClientesPorNombre(nombre);

            foreach (Cliente cliente in listaClientes)
            {
                cliente.cargarTelefonos();
                cliente.cargarMails();
            }

            return listaClientes;
        }

        private List<Cliente> buscarClientesActivosYAutorizados()
        {
            listaClientes = clientesBD.buscarClientesActivosYAutorizados();

            foreach (Cliente cliente in listaClientes)
            {
                cliente.cargarTelefonos();
                cliente.cargarMails();
            }

            return listaClientes;
        }

        private List<Cliente> buscarClientesPorTipo(string valFiltro)
        {
            listaClientes = clientesBD.buscarClientesPorTipo(valFiltro);

            foreach (Cliente cliente in listaClientes)
            {
                cliente.cargarTelefonos();
                cliente.cargarMails();
            }

            return listaClientes;
        }

        private List<Cliente> buscarClientesActivosOInactivos(bool valFiltro)
        {
            listaClientes = clientesBD.buscarClientesActivos(valFiltro);

            foreach (Cliente cliente in listaClientes)
            {
                cliente.cargarTelefonos();
                cliente.cargarMails();
            }

            return listaClientes;
        }

        private List<Cliente> buscarClientesAutorizadosONoAutorizados(bool valFiltro)
        {
            listaClientes = clientesBD.buscarClientesAutorizados(valFiltro);

            foreach (Cliente cliente in listaClientes)
            {
                cliente.cargarTelefonos();
                cliente.cargarMails();
            }

            return listaClientes;
        }


        // Autorizacion
        public bool autorizarCliente(int idCliente)
        {
            return clientesBD.autorizarCliente(idCliente, true);
        }

        // Alta / baja
        public bool altaCliente(int idCliente)
        {
            return clientesBD.altaBajaCliente(idCliente, true);
        }

        public bool bajaCliente(int idCliente)
        {
            return clientesBD.altaBajaCliente(idCliente, false);
        }


    }
}
