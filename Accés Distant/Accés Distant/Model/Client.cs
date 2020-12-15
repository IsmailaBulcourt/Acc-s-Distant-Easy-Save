using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows;


namespace Accés_Distant
{
    class Client
    {
        public static void StartClient(IPAddress ipAddress)
        {
            // Data buffer for incoming data.  
            byte[] bytes = new byte[1024];

            // Connect to a remote device.  
            try
            {
                
                // Establish the remote endpoint for the socket.  
                // This example uses port 11000 on the local computer.  
                IPEndPoint remoteEP = new IPEndPoint(ipAddress, 25565);

                // Create a TCP/IP  socket.  
                Socket sender = new Socket(ipAddress.AddressFamily,
                SocketType.Stream, ProtocolType.Tcp);

                // Connect the socket to the remote endpoint. Catch any errors.  
                try
                {
                    sender.Connect(remoteEP);

                    MessageBox.Show("Socket connected to {0}",
                        sender.RemoteEndPoint.ToString());

                    // Encode the data string into a byte array.  
                    byte[] msg = Encoding.ASCII.GetBytes("This is a test<EOF>");

                    // Send the data through the socket.  
                    int bytesSent = sender.Send(msg);

                    // Receive the response from the remote device.  
                    int bytesRec = sender.Receive(bytes);
                    MessageBox.Show("Echoed test = {0}",
                        Encoding.ASCII.GetString(bytes, 0, bytesRec));

                    // Release the socket.  
                    sender.Shutdown(SocketShutdown.Both);
                    sender.Close();

                }
                catch (ArgumentNullException ane)
                {
                    MessageBox.Show("ArgumentNullException : {0}", ane.ToString());
                }
                catch (SocketException se)
                {
                    MessageBox.Show("SocketException : {0}");
                    MessageBox.Show(se.ToString());
                }
                catch (Exception e)
                {
                    MessageBox.Show("Unexpected exception : {0}", e.ToString());
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

    }
}
