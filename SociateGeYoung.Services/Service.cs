using SociateGeYoung.Data;

namespace SociateGeYoung.Services
{
    public class Service
    {
        protected SociateGeYoungContext Context;

        public Service()
        {
            this.Context = new SociateGeYoungContext();
        }
    }
}