namespace Rpg
{
    class Caracteristica
    {
       private int tipoCabelo;
       private int corCabelo;
       private int tipoOlho;
       private int corOlho;
       
       public int getTipoCabelo()
       {
           return this.tipoCabelo;
       }
       public int getCorCabelo()
       {
           return this.corCabelo;
       }
       public int getTipoOlho()
       {
           return this.tipoOlho;
       }
       public int getCorOlho()
       {
           return this.corOlho;
       }
       public void setTipoOlho(int tipoOlho)
       {
           this.tipoOlho = tipoOlho;
       }
       public void setCorOlho(int corOlho)
       {
           this.corOlho = corOlho;
       }
       public void setTipoCabelo(int tipoCabelo)
       {
           this.tipoCabelo = tipoCabelo;
       }
       public void setCorCabelo(int corCabelo)
       {
           this.corCabelo = corCabelo;
       }
    }

}