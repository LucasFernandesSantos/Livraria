using Livraria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Livraria.DAO
{
    public class ReservaLivroDAO
    {
        private readonly Context _context;
        public ReservaLivroDAO(Context context)
        {
            _context = context;
        }

        public List<ReservaLivro> ListarReservas()
        {
            return _context.Reservas.ToList();
        }

        public ReservaLivro SalvarReserva(ReservaLivro reservaLivro)
        {
            _context.Reservas.Add(reservaLivro);
            _context.SaveChanges();
            return reservaLivro;
        }
    }
}
