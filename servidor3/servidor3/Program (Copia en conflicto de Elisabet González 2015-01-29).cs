/* program.cs
 * Descripción:
 * Servidor con protocolo TCP.
 * Despliega un mensaje para indicar que la conexión se realizó correctamente.
 * Recive datos del cliente.
 * Fecha: 22 de enero de 2015
 * Versión 1.2
 * Modificaciones:
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Collections;

namespace servidor
{
    class Program
    {
        static TcpListener Servidor;
        static Hashtable Cliente;
        static void Main(string[] args)
        {
            String MensajeCliente;
            try
            {
                // Realiza conexión.
                Servidor = new TcpListener(IPAddress.Parse("127.0.0.1"), 4444);
                Cliente = new Hashtable();
                Servidor.Start();
                Console.WriteLine("Servidor Conectado");

                while (true)
                {
                    TcpClient Cl = Servidor.AcceptTcpClient();
                    Byte[] msj = new Byte[140];
                    NetworkStream NetworkCliente = Cl.GetStream();
                    NetworkCliente.Read(msj, 0, msj.Length);
                    MensajeCliente = Encoding.ASCII.GetString(msj, 0, msj.Length);
                    Cliente.Add(MensajeCliente, Cl);
                    // Envía un mensaje a todos los clientes.
                    msj_todos(MensajeCliente, MensajeCliente);

                    chat nuevo = new chat(MensajeCliente, Cl);
                }
            }
            catch
            {
                Console.WriteLine("Error al conectar con el servidor");
            }
            finally
            {
                Servidor.Stop();
            }
        }
        public static void msj_todos(String Mensaje, String Nombre)
        {
            foreach (DictionaryEntry c in Cliente)
            {
                Byte[] uno = null;
                TcpClient cliente_conectado = (TcpClient)c.Value;
                NetworkStream strin = cliente_conectado.GetStream();
                uno = Encoding.ASCII.GetBytes(Nombre + " : " + Mensaje);
                strin.Write(uno, 0, uno.Length);
                strin.Flush();
                Console.WriteLine(Nombre + " : " + Mensaje);
            }
        }
    }
    class chat
    {
        String nombre;
        TcpClient Cliente_clase;
        public chat(String nombres, TcpClient Cliente_clases)
        {
            nombre = nombres;
            Cliente_clase = Cliente_clases;
            Thread hilo = new Thread(chat_action);
            hilo.Start();
        }
        public void chat_action()
        {
            String MensajeCliente;
            while (true)
            {
                Byte[] msj = new Byte[140];
                NetworkStream NetworkCliente = Cliente_clase.GetStream();
                NetworkCliente.Read(msj, 0, msj.Length);
                MensajeCliente = Encoding.ASCII.GetString(msj, 0, msj.Length);
                // Envía un mensaje a todos los clientes.
                Program.msj_todos(MensajeCliente, nombre);
            }
        }
    }
}