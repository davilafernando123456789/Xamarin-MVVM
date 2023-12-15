using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace Trigger.Services
{
    public class CompraService
    {
        private readonly AppDbContext _context;

        public CompraService() => _context = App.GetContext();


        public bool Create(Compra item)
        {
            try
            {
                //EntityFrameworkCore
                _context.Buys.Add(item);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }



        public bool CreateRange(List<Compra> items)
        {
            try
            {
                //EntityFrameworkCore
                _context.Buys.AddRange(items);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<Compra> Get()
        {
            return _context.Buys.ToList();
        }


        public List<Compra> GetByText(string text)
        {
            return _context.Buys.Where(x => x.FirstName.Contains(text)).ToList();
        }



    }
}
