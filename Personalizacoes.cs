namespace Rpg
{
    class Personalizacoes
    {   
        #region cabelos

        private static Caracteristica Liso()
        {
           Caracteristica liso = new Caracteristica();
           liso.setTipoCabelo(1);

           
           return liso;
        }
        
        private static Caracteristica Curto()
        {
           Caracteristica curto = new Caracteristica();
           curto.setTipoCabelo(2);

           
           return curto;
        }
        private static Caracteristica cabeloBranco()
        {
            Caracteristica branco = new Caracteristica();
            branco.setCorCabelo(1);


            
            return branco;
        }
        private static Caracteristica cabeloPreto()
        {
            Caracteristica preto = new Caracteristica();
            preto.setCorCabelo(2);


            return preto;
        }
        #endregion
        #region olhos
            
        private static Caracteristica Puxado_e_fechado()
        {
            Caracteristica puxado_e_fechado = new Caracteristica();
            puxado_e_fechado.setTipoOlho(1);
            return puxado_e_fechado;
        }
        private static Caracteristica Cansados()
        {
            Caracteristica olhoscansados = new Caracteristica();
            olhoscansados.setTipoOlho(2);
            return olhoscansados;
        }
        private static Caracteristica Abertos()
        {
            Caracteristica olhosabertos = new Caracteristica();
            olhosabertos.setTipoOlho(3);
            return olhosabertos;
        }
        private static Caracteristica SemOlhos()
        {
            Caracteristica sem_olhos = new Caracteristica();
            sem_olhos.setTipoOlho(-1);
            return sem_olhos;
        } 
        private static Caracteristica Amarelo()
        {
            Caracteristica amarelo = new Caracteristica();
            amarelo.setCorOlho(1);
            return amarelo;
        }
        private static Caracteristica Branco()
            {
                Caracteristica branco = new Caracteristica();
                branco.setCorOlho(2);
                return branco;
            }
        private static Caracteristica Azul()
            {
                Caracteristica azul = new Caracteristica();
                azul.setCorOlho(3);
                return azul;
            }
        private static Caracteristica Preto()
            {
                Caracteristica preto = new Caracteristica();
                preto.setCorOlho(4);
                return preto;
            }
        private static Caracteristica Rosa()
            {
                Caracteristica rosa = new Caracteristica();
                rosa.setCorOlho(5);
                return rosa;
            }
        #endregion

        public static List<Caracteristica> Escolha()
        {
            List<Caracteristica> cabelos = new List<Caracteristica>();
            cabelos.Add(Liso());
            cabelos.Add(Curto());
            cabelos.Add(cabeloBranco());
            cabelos.Add(cabeloPreto());
            return cabelos;
        }
        public static List<Caracteristica> EscolhaOlho()
        {
           List<Caracteristica> olhos = new List<Caracteristica>();
           olhos.Add(Puxado_e_fechado());
           olhos.Add(Cansados());
           olhos.Add(Abertos());
           olhos.Add(SemOlhos());
           olhos.Add(Amarelo());
           olhos.Add(Branco());
           olhos.Add(Azul());
           olhos.Add(Preto());
           olhos.Add(Rosa());
           return olhos;    
        }
    }
}