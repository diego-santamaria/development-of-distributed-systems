namespace WCFServiceAPI
{
    public class ReniecAPI : IReniecAPI
    {
        public Tecactus.Api.Reniec.Person Consultar(string dni)
        {
            var dniobj = new Tecactus.Api.Reniec.Dni("Cdq8B6yNTXUgHCqTqF4NzdsfayW9ZI7vt4GvZfch");

            var obj = dniobj.get(dni);

            return obj;
        }
    }
}
