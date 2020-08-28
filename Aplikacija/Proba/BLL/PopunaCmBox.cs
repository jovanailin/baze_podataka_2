using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proba.DAL;
using Proba.BLL;
using Proba.UIL;
using System.Windows.Forms;

namespace Proba.BLL
{

    public class PopunaCmBox
    {
        public MestoBLL mesto;
        public UlicaBLL ulica;
        public AdresaBLL adresa;
        public ProizvodBLL proizvod;
        public VrstaBLL vrstaproizvoda;
        public JedinicaMereBLL jm;
        public KupacBLL kupac;
        public RacunBLL racun;
        public StavkaRacunaBLL stavkaracuna;
       



        public PopunaCmBox()
        {
            mesto = new MestoBLL();
            ulica = new UlicaBLL();
            adresa = new AdresaBLL();
            proizvod = new ProizvodBLL();
            vrstaproizvoda = new VrstaBLL();         
            jm = new JedinicaMereBLL();
            kupac = new KupacBLL();
            racun = new RacunBLL();
            stavkaracuna = new StavkaRacunaBLL();
            
            

        }

       

       
        public void popuniCmbMesto(ComboBox cmb)
        {
            cmb.DataSource = null;
            cmb.Items.Clear();
            cmb.DataSource = mesto.dajMesto();
            cmb.ValueMember = "ID_Mesta";
            cmb.DisplayMember = "mesto";
            cmb.Text = null;
        }

        public void popuniCmbUlica(ComboBox cmb)
        {
            cmb.DataSource = null;
            cmb.Items.Clear();
            cmb.DataSource = ulica.dajUlicu();
            cmb.ValueMember = "ID_Ulice";
            cmb.DisplayMember = "ulica";
            cmb.Text = null;
        }

        public void popuniCmbAdresa(ComboBox cmb)
        {
            cmb.DataSource = null;
            cmb.Items.Clear();
            cmb.DataSource = adresa.dajAdresu();
            cmb.ValueMember = "ID_Adrese";
            cmb.DisplayMember = "adresa";
            cmb.Text = null;
        }
        
       

        public void popuniCmbProizvod(ComboBox cmb)
        {
            cmb.DataSource = null;
            cmb.Items.Clear();
            cmb.DataSource = proizvod.dajProizvod();
            cmb.ValueMember = "ID_Proizvoda";
            cmb.DisplayMember = "proizvod_podaci";
            cmb.Text = null;
        }

           public void popuniCmbVrstaProizvoda(ComboBox cmb)
        {
            cmb.DataSource = null;
            cmb.Items.Clear();
            cmb.DataSource = vrstaproizvoda.dajVrstuProizvoda();
            cmb.ValueMember = "ID_vrste_proizvoda";
            cmb.DisplayMember = "vrsta";
            cmb.Text = null;
        }

         

           public void popuniCmbJM(ComboBox cmb)
           {
               cmb.DataSource = null;
               cmb.Items.Clear();
               cmb.DataSource = jm.dajJM();
               cmb.ValueMember = "id_jedinice_mere";
               cmb.DisplayMember = "Naziv_jedinice_mere";
               cmb.Text = null;
           }

           public void popuniCmbKupac(ComboBox cmb)
           {
               cmb.DataSource = null;
               cmb.Items.Clear();
               cmb.DataSource = kupac.dajKupca();
               cmb.ValueMember = "id_Kupca";
               cmb.DisplayMember = "kupac";
               cmb.Text = null;
           }

           public void popuniCmbRacun(ComboBox cmb)
           {
               cmb.DataSource = null;
               cmb.Items.Clear();
               cmb.DataSource = racun.dajRacun();
               cmb.ValueMember = "id_Racuna";
               cmb.DisplayMember = "Racun";
               cmb.Text = null;
           }

          

           public void dajPregledStavkiRacuna(DataGridView dgv, int b)
           {

               dgv.DataSource = null;
               dgv.DataSource = stavkaracuna.dajStavkuRacuna(b); //prosledi sifru racuna

           }

          
    }
}

