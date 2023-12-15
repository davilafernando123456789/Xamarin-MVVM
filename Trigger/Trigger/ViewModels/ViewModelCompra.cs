using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace Trigger.ViewModels

{
    public class ViewModelCompra : BaseViewModels
    {
        private string color;
        public string Color
        {
            get { return this.color; }
            set { SetValue(ref this.color, value); }
        }

        private string fecha;
        public string fecha
        {
            get { return this.fecha; }
            set { SetValue(ref this.fecha, value); }
        }

        private string cliente;
        public string cliente
        {
            get { return this.cliente; }
            set { SetValue(ref this.cliente, value); }
        }

        private string vendedor;
        public string vendedor
        {
            get { return this.vendedor; }
            set { SetValue(ref this.vendedor, value); }
        }

        private string total;
        public string total
        {
            get { return this.total; }
            set { SetValue(ref this.total, value); }
        }



        private string filter;
        public string Filter
        {
            get { return this.filter; }
            set { SetValue(ref this.filter, value); }
        }

        private List<Compra> buys;
        public List<Compra> Buys
        {
            get { return this.buys; }
            set { SetValue(ref this.buys, value); }
        }


        public ICommand SearchCommand { get; set; }
        public ICommand InsertCommand { get; set; }

        public ViewModelCompra()
        {

            SearchCommand = new Command(() =>
            {
                CompraService service = new CompraService();
                Buys = service.GetByText(Filter);


            });

            InsertCommand = new Command(() =>
            {
                CompraService service = new CompraService();
                int newPersonId = service.Get().Count + 1;
                service.Create(new Compra { Fecha = Fecha, Cliente = Cliente, Vendedor = Vendedor, Total = Total, CompraId = newCompraId });

                App.Current.MainPage.DisplayAlert("Success", "Your data are saved", "Ok");
            });
        }
    }
}