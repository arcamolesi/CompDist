using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public int Soma (int v1, int v2)
        {
            int sm = v1 + v2;
            return sm; 
        }

        public void inserirProdutos(Produto produto)
        {
            Contexto contexto = new Contexto();
            contexto.Produtos.Add(produto);
            contexto.SaveChanges(); 
        }


        public List<Produto> lProdutos() {
            Contexto contexto = new Contexto();
            return contexto.Produtos.ToList(); 
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
