using NouApi.Models;
using System;
using System.Linq;

namespace NouApi.Data
{
    public class SqlMessageRepo : IMessageRepo
    {
        private readonly ApplicationDbContext _context;

        public SqlMessageRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public void CreateMessage(Message message)
        {
            if (message == null)
            {
                throw new ArgumentNullException(nameof(message));
            }

            _context.Messages.Add(message);
        }

        public Message GetLatestMessage()
        {
            return _context.Messages.FirstOrDefault();
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges()) > 0;
        }
    }
}
