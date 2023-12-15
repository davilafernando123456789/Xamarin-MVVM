using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Trigger.Models
{
    public class Compra
    {
        public int CompraId { get; set; }
        public string Fecha { get; set; }
        public string Cliente { get; set; }
        public string Vendedor { get; set; }
        public string Total { get; set; }
    }
}
