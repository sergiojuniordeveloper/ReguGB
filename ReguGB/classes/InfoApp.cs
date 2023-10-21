using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReguGB.classes
{
    public class InfoApp
    {
        //Informações para colocar no commit do Git
        /*
        Primeiro Commit - Últimos ajustes realizados até 21/10/2023 às 13:13hs.
        
        */

        public const string mApp_Nome = "SJ ReguaGB"; //Regua e Código para GunBound
        public const string mApp_Versao = "1.0.0.0";
        public const string mApp_DataHoraUltimaCombipilacao = "21/10/2023 às 13:13hs.";

        public static string GerarTituloForm(string pNomeDoForm, bool pAcrescentarNomeNumeroEDataDaVersao = true, string pAcrescentarTextoNoFinalDoTitulo = "")
        {
            string ret = pNomeDoForm;

            if (pAcrescentarNomeNumeroEDataDaVersao) {
                if ( !string.IsNullOrEmpty(ret))
                    ret += " - ";

                    ret +=  InfoApp.mApp_Nome + " - Versão: " + InfoApp.mApp_Versao + ", Compilado em: " + InfoApp.mApp_DataHoraUltimaCombipilacao;
            }


            if (!string.IsNullOrEmpty(pAcrescentarTextoNoFinalDoTitulo))
            {
                if (!string.IsNullOrEmpty(ret))
                    ret += " - ";

                ret += pAcrescentarTextoNoFinalDoTitulo;
            }

            return ret;
        }
    }
}
