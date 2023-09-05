using Ejemplo1_Ap1.Data;
using Ejemplo1_Ap1.Models;
using Microsoft.EntityFrameworkCore;

namespace Ejemplo1_Ap1.BLL;

public class TicketsBLL
{
    private readonly Contexto _contexto;
    public TicketsBLL(Contexto contexto)
    {
        _contexto = contexto;
    }

    public bool Save(Tickets ticket)
    {
        _contexto.Tickets.Add(ticket);

        var saved = _contexto.SaveChanges() > 0;
        return saved;
    }

    public List<Tickets> GetTickets()
    {
       var lista= _contexto.Tickets
            .AsNoTracking()
            .ToList();

        return lista;
    }
}
