using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using ProyectoITXamarin;

namespace ProyectoITXamarin.DataModel
{
    //public class Cliente : ModelObject
    //{
    //    string codigo;
    //    string name;
    //    string ruc;
    //    public Cliente()
    //    {
    //        this.codigo = "";
    //        this.name = "";
    //        this.ruc = "";
    //    }
    //    public Cliente(string codigo, string name, string ruc)
    //    {
    //        this.codigo = codigo;
    //        this.name = name;
    //        this.ruc = ruc;
    //    }
    //    public string Codigo
    //    {
    //        get { return codigo; }
    //        set { if (codigo != value)
    //            {
    //                codigo = value;
    //                RaisePropertyChanged("Codigo");
    //            } }
    //    }
    //    public string Name
    //    {
    //        get { return name; }
    //        set
    //        {
    //            if (name != value)
    //            {
    //                name = value;
    //                RaisePropertyChanged("Name");
    //            }
    //        }
    //    }
    //    public string Ruc
    //    {
    //        get { return ruc; }
    //        set
    //        {
    //            if (ruc != value)
    //            {
    //                ruc = value;
    //                RaisePropertyChanged("Ruc");
    //            }
    //        }
    //    }
    //}
    //public class ModelObject : INotifyPropertyChanged
    //{
    //    public event PropertyChangedEventHandler PropertyChanged;

    //    protected void RaisePropertyChanged(string name)
    //    {
    //        if (PropertyChanged != null)
    //            PropertyChanged(this, new PropertyChangedEventArgs(name));
    //    }
    //}
    public class Cliente
    {
        string name;
        public string Name
        {
            get => this.name;
            set
            {
                this.name = value; 
            }
        }

        public Cliente(string name, string ruc, string codigo)
        {
            Name = name;
            Ruc = ruc;
            Codigo = codigo;
        }
        public string Ruc { get; set; }
        public string Codigo { get; set; }
    }

    public class ViewModel : INotifyPropertyChanged
    {
        //public List<Cliente> Data { get; }
        //public ViewModel()
        //{
        //    Data = new List<Cliente>();
        //}
        public List<Cliente> Clientes { get; }
        Cliente selectedCliente;
        public Cliente SelectedCliente
        {
            get { return selectedCliente; }
            set
            {
                if (selectedCliente != value)
                {
                    selectedCliente = value;
                }
            }
        }

        public ViewModel()
        {
            Clientes = new List<Cliente>();
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
    
}