using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleCore001
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (coredbContext context = new coredbContext())
            {
                var usr = context.User.FirstOrDefault(m => m.Id == 1);
                if (usr != null)
                {
                    context.User.Remove(usr);
                    context.SaveChanges();
                }
                context.User.Add(new User() { Id = 1, Age = 29, City = "北京", Name = "xleoguo" });
                context.SaveChanges();
                Console.WriteLine(context.User.FirstOrDefault().Name);
            }
            var app = AppContext.BaseDirectory;
            Console.Read();
        }
    }
}
