using Livraria.Models;
using Microsoft.EntityFrameworkCore;
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

        public void UpdateReserva(ReservaLivro reservaLivro)
        {
            _context.Reservas.Add(reservaLivro);
            _context.SaveChanges();
        }

        public List<ReservaLivro> ListarReservas()
        {
            return _context.Reservas.ToList();
        }
        public List<ReservaLivro> ReservaDoCliente(int id)
        {
            return _context.Reservas.Where(x => x.ClienteId==id).Where(x => x.StatusR.Equals("Disponivel")).Include(x => x.DadosLivro).Include(x => x.Cliente).ToList();
        }
        public List<ReservaLivro> ListaReservaAdm()
        {
            return _context.Reservas.Where(x => x.StatusR.Equals("Cancelado")).Include(x => x.DadosLivro).Include(x => x.Cliente).ToList();
        }


        public ReservaLivro SalvarReserva(ReservaLivro reservaLivro)
        {
            _context.Reservas.Add(reservaLivro);
            _context.SaveChanges();
            return reservaLivro;
        }
        public void Update(ReservaLivro reservaLivro)
        {
            _context.Reservas.Update(reservaLivro);
            _context.SaveChanges();
        }

        public ReservaLivro BuscarPorID(int? id)
        {
            return _context.Reservas.Find(id);
        }
    }
}
