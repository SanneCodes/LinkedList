using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkedList
{
    public partial class F1LinkedList : Form
    {
        public F1LinkedList()
        {
            InitializeComponent();
        }

        LinkedList<string> butikker = new LinkedList<string>();

        private void F1LinkedList_Load(object sender, EventArgs e)
        {
            //legger til butikker i "butikker" linked listen
            butikker.AddLast("Kiwi");
            butikker.AddLast("Rema1000");
            butikker.AddLast("SparKjøp");
            //oppdaterer tabellen slik at verdiene er der på start
            update();
        }

        //lager update metode som oppdaterer displayet, dette lager jeg slik at jeg kan kalle på den istedenfor å skrive den samme koden hele tiden
        private void update()
        {
            //clear alt i display
            txtListDisplay.Text = string.Empty;
            //bruk foreach loop for å gå gjennom hver item
            foreach (var item in butikker)
            {//plusser på 1 og 1 item til displayet, og legger til et nedhakk slik at det er mer ryddig med "\r\n\"
                txtListDisplay.Text += item + "\r\n";
            }
        }

        
        private void btnLeggTilØverst_Click(object sender, EventArgs e)
        {//knapp for å legge til en item øverst
            butikker.AddFirst(txtLeggTil.Text); // bruker .AddFirst() for å legge til item øverst
            update();//kaller update metoden etter hver endring for å vise endringene i listen
        }

        private void btnLeggTilNederst_Click(object sender, EventArgs e)
        {//knapp for å legge til nederst
            butikker.AddLast(txtLeggTil.Text); //bruker .AddLast() for å legge til item nederst
            update();
        }

        private void btnLeggTilForan_Click(object sender, EventArgs e)
        {
            int index = int.Parse(txtSkrivNr.Text) - 1;
            string butikk = txtSkrivText.Text;
            LinkedListNode<String> currentNode = butikker.First;

            for (int i = 0; i <= index && currentNode != null; i++)
            {
                if (i != index)
                {
                    currentNode = currentNode.Next;
                    continue;
                }

                butikker.AddBefore(currentNode, butikk); 

                update();
            }
        }

        private void btnLeggTilBak_Click(object sender, EventArgs e)
        {
            int index = int.Parse(txtSkrivNr.Text) - 1;
            string butikk = txtSkrivText.Text;
            LinkedListNode<String> currentNode = butikker.First;

            for (int i = 0; i <= index && currentNode != null; i++)
            {
                if (i != index)
                {
                    currentNode = currentNode.Next;
                    continue;
                }

                butikker.AddAfter(currentNode, butikk);

                update();
            }
        }

        private void btnSlettØverst_Click(object sender, EventArgs e)
        {
            butikker.RemoveFirst();
            update();
        }

        private void btnSlettNederst_Click(object sender, EventArgs e)
        {
            butikker.RemoveLast();
            update();
        }

        private void btnSlettListe_Click(object sender, EventArgs e)
        {
            butikker.Clear();
            update();
        }
        private void btnSlett_Click(object sender, EventArgs e)
        {
            int index = int.Parse(TxtSlett.Text) - 1;
            LinkedListNode<String> currentNode = butikker.First;

            for (int i = 0; i <= index && currentNode != null; i++)
            {
                if (i != index)
                {
                    currentNode = currentNode.Next;
                    continue;
                }

                butikker.Remove(currentNode);
                
                update();
            }

        }

        private void btnAvslutt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
