﻿using CTZ.Controlador;
using CTZ.Controler.Instruments.Accessory;
using CTZ.Controler.Instruments.Assignments_;
using CTZ.Model.Browser.Interfaces;
using CTZ.Modelo.Browser;
using CTZ.Vista.Responsabilitis;
using MaterialSkin.Controls;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CTZ.Vista.Instruments
{
    public partial class Add_Delivery_Instrument_ByGroup : MaterialForm
    {
        private C_Instruments instrumentsControler;
        private C_Regist_Delivery_Instrument assignmentController;
        private C_User usuarioControler;
        private C_Regist_Delivery_Accessories controllerAccessories;

        public static Instrument_Assignments instrumentAssignments;
        private static List<string> instrumentsThatNeedCertificate;
        private static List<string> instrumentList;
        private static List<string> accessoriesList = new List<string>();

        private DataTable engineers;
        private string equinoInstrument;

        public Add_Delivery_Instrument_ByGroup()
        {
            InitializeComponent();
            instrumentList = new List<string>();
            instrumentsThatNeedCertificate = new List<string>();

            UserRepository userRepository = new UserRepository();
            usuarioControler = new C_User(userRepository);
            engineers = usuarioControler.getEngineers();

            instrumentAssignments = new Instrument_Assignments();
            instrumentAssignments.EngineerSignature = "";
            fillMaterialComboBoxEngineers();
        }

        private void fillMaterialComboBoxEngineers()
        {
            for (int i = 0; i < engineers.Rows.Count; i++)
            {
                string completeNameEngineer = engineers.Rows[i]["Nombre"].ToString() + " " + engineers.Rows[i]["Apellidos"].ToString();
                MaterialComboBox_Engineers.Items.Add(completeNameEngineer);
            }
        }

        private void Btn_Add_Equino_Click(object sender, EventArgs e)
        {
            instrumentsControler = new C_Instruments();
            if (instrumentsControler.serchInstrument(TxtBox_Instrumenst.Text))
            {
                DataTable instrumentInformation = instrumentsControler.selectAllFromInstrument(TxtBox_Instrumenst.Text);
                bool instrumentIsAvailable = instrumentsControler.checkIfInstrumentIsAvailable(TxtBox_Instrumenst.Text);

                equinoInstrument = instrumentInformation.Rows[0]["ID_Instrumentos"].ToString();

                if (instrumentIsAvailable)
                {
                    if (Btn_Add_Accessories.Visible == true)
                    {
                        MessageBox.Show("No puedes agregar otro instrumento si no has registrado" +
                            "los accesorios del primero");
                    }
                    else
                    {
                        this.checkExpirationOfCertificate(equinoInstrument);
                    }                   
                }
                else
                {
                    MessageBox.Show("Este Instrumento esta Ocupado");
                }
            }
            else
            {
                MessageBox.Show("Instrumento No Existe");
            }
        }

        private void Btn_Delete_Instrument_Click(object sender, EventArgs e)
        {
            try
            {
                controllerAccessories = new C_Regist_Delivery_Accessories();
                controllerAccessories.updateStatusAssignment
                    (ComboBox_Instruments.SelectedItem.ToString(), "");
                MessageBox.Show("Se eliminaron todos los accesorios de los instrumentos");
            }
            catch(Exception ex)
            {
                Trace.WriteLine(ex.ToString());
            }

            CTZ.Vista.Responsabilitis.Instrument instrument = new CTZ.Vista.Responsabilitis.Instrument();                 
            instrument.deleteEquinoFromComboBox(ComboBox_Instruments);
        }

        private void checkExpirationOfCertificate(string equinoInstrument)
        {
            assignmentController = new C_Regist_Delivery_Instrument();
            bool InstrumentCertificateIsCloseToExpirin = assignmentController.checkIfInstrumentCertificateIsCloseToExpiring(equinoInstrument);
            if (InstrumentCertificateIsCloseToExpirin)
            {
                MessageBox.Show("Faltan menos de 10 dias para la calibracion de este instrumento " + equinoInstrument + " \n" +
                        "NO puede ser asignado");
            }
            else
            {
                addEquino(equinoInstrument);
            }
        }

        private void addEquino(string equinoInstrument)
        {
            instrumentList.Add(equinoInstrument);
            ComboBox_Instruments.Items.Add(equinoInstrument);

            this.checkIfEngineerNeedCertificate(equinoInstrument);
            this.checkIfNeedAllAccessoriesOfInstrument(equinoInstrument);
            MessageBox.Show("Se agrego Equino " + equinoInstrument);
            TxtBox_Instrumenst.Clear();
        }

        private void checkIfEngineerNeedCertificate(string equinoInstrument)
        {
            DialogResult resultado = MessageBox.Show("¿Quieres que se envie certificado de este instrumento?", "Pregunta",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                instrumentsThatNeedCertificate.Add(equinoInstrument);
            }
        }

        private void checkIfNeedAllAccessoriesOfInstrument(string equinoInstrument)
        {
            DialogResult resultado = MessageBox.Show("¿Prestaras todos los accesorios del Instrumento?", "Pregunta",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Btn_Add_Accessories.Visible == true)
            {
                MessageBox.Show("Debes registrar los accesorios " +
                    "del instrumento anterior antes de registrar otros");
            }
            else
            {
                if (resultado == DialogResult.No)
                {
                    C_Manage_Accessories controller = new C_Manage_Accessories();
                    List<Accesorios_Instrumento> accessoriesList = controller.selectAvailableAccessories(equinoInstrument);
                    this.fillAccessoriesList(accessoriesList);
                    Btn_Add_Accessories.Visible = true;
                }
                else
                {
                    controllerAccessories = new C_Regist_Delivery_Accessories();
                    controllerAccessories.updateStatusAssignment(equinoInstrument,"PRESTADO");
                }
            }         
        }

        private void fillAccessoriesList(List<Accesorios_Instrumento> accessoriesList)
        {
            CheckedList_Accessories.Visible = true;
            foreach (var accessory in accessoriesList)
            {
                CheckedList_Accessories.Items.Add(accessory.Id_Accesorio);
            }
        }

        private void Btn_AddEnginnerSignature_Click(object sender, EventArgs e)
        {
            RegistSignature signature = new RegistSignature(instrumentAssignments, "Engineer");
            signature.Show();
        }

        private void Btn_Regist_kit_Click(object sender, EventArgs e)
        {
            if (MaterialComboBox_Engineers.SelectedItem == null)
            {
                MessageBox.Show("No haz seleccionado al Ingeniero");
            }
            else
            {
                if (instrumentAssignments.EngineerSignature.Equals(""))
                {
                    MessageBox.Show("No puedes registrar el prestamo de instrumento sin la firma del ingeniero");
                }
                else
                {
                    UserRepository userRepository = new UserRepository();
                    usuarioControler = new C_User(userRepository);
                    string emailEngineer = usuarioControler.serchEmailEngineer(MaterialComboBox_Engineers.SelectedItem.ToString());

                    instrumentAssignments.DateDelivery = TimePicker_Date_Delivery.Text;
                    instrumentAssignments.Engineer = MaterialComboBox_Engineers.Text;
                    instrumentAssignments.NumberEnterprise = TxtBox_Enterprise.Text;
                    instrumentAssignments.DeliveryObservations = TxtBox_ObservationDelivery.Text;
                    instrumentAssignments.EstimateDateReturn = TimePicker_Date_Estimate_Return.Text;
                    instrumentAssignments.NameEnterprise = TxtBox_NameEnterprise.Text;
                    instrumentAssignments.EngineerEmail = emailEngineer;
                    instrumentAssignments.equinoInstrument = equinoInstrument;
                    instrumentAssignments.type = "Prestamo";

                    assignmentController = new C_Regist_Delivery_Instrument();
                    assignmentController.registerDeliveryInstrument(instrumentAssignments, instrumentList, instrumentsThatNeedCertificate);
                    MessageBox.Show("Prestamo de Instrumento(s) realizado correctamente");

                    controllerAccessories.updateStatusAssignment(accessoriesList, "PRESTADOS");
                    this.Close();
                }               
            }
        }

        private void Btn_Add_Accessories_Click(object sender, EventArgs e)
        {
            foreach (string accessory in CheckedList_Accessories.CheckedItems)
            {
                accessoriesList.Add(accessory);
            }       
            MessageBox.Show("Accesorios agregados correctamente");

            CheckedList_Accessories.Items.Clear();
            CheckedList_Accessories.Visible = false;
            Btn_Add_Accessories.Visible = false;
        }
    }
}