using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MusteriManager : CRUDS
    {
        
      
       
           
        public void Add()
        {
          
            
            Console.WriteLine("EKLEME başarılı");
            
        }

        public void Delete()
        {
            
            Console.WriteLine("SİLME başarılı");
        }

        public void List()
        {
            ;
            Console.WriteLine("LİSTELEME başarılı");
        }

        public void Upgrade()
        {
            
            Console.WriteLine("GÜNCELLEME başarılı");
        }
    }
}
