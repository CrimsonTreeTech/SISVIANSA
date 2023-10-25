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
        private string calle, esq;
        private int id, nroPuerta;
        private bool activo, autorizado;
        private long doc;
        private List<string> mails;
        private List<int> tels;
        private List<Cliente> listaClientes;
        private ClientesBD clientesBD;

        // Comun
        private string pNom, sNom, pApe, sApe, tipoDoc;
        private ClienteComunBD clienteComunBD;

        // Empresa
        private string nombre;
        private ClienteEmpresaBD clienteEmpresaBD;

        


        // --------------- CONSTRUCTOR --------------------
        public Cliente(byte rol)
        {
            this.rol = rol;
            clienteComunBD = new ClienteComunBD(rol);
            clienteEmpresaBD = new ClienteEmpresaBD(rol);
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

        public string NombreEmpresa
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

        public List<string> Mails
        {
            get { return mails; }
            set { mails = value; }
        }

        public List<int> Tels
        {
            get { return tels; }
            set { tels = value; }
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

        public List<Cliente> realizarBusquedaFiltrada(string colFiltro, string valFiltro)
        {
            listaClientes = new List<Cliente>();

            if(colFiltro.Equals("nro_doc"))
                buscarClientesPorNroDoc(valFiltro);

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

        



    }
}
