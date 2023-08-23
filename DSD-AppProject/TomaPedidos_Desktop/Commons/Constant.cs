using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TomaPedidos.Commons
{
    public static class Constant
    {

        //Constantes útiles
        public static string OK = "OK";
        public static string ERR = "ERROR";
        public static string AppVersion = "v1.0.0";
        public static string GenericClient = "C99999999";
        //public static string MsgTitle = "Sistema de gestión de oportunidades AGN Ingenieros S.A.";

        //** A falta de BD, se han creado Arrays que proporcionan la data que especifica el cliente en el Boceto.
        #region ArraysComboBoxes


        //Constantes ComboBoxes - Conversiones
        //public static string[] ArrayListCilMotor3 = new string[3] { "800", "900", "1000" };
        //public static  string[] ArrayListCilMotor4 = new string[13] { "900", "1000", "1200", "1300", "1400", "1500", "1600", 
        //                                                "1800", "2000", "2200", "2400", "2700", "2800"};
        //public static string[] ArrayListCilMotor6 = new string[5] { "2800", "3000", "3500", "3700", "4000" };
        //public static string[] ArrayListCilMotor8 = new string[3] { "4000", "4700", "5200" };
        //public static string[] ArrayListGLP = new string[21] {"CILINDRICO 6.5GL","CILINDRICO 7.5GL", "CILINDRICO 9GL", "CILINDRICO 10.5GL",
        //                                                      "CILINDRICO 12.5GL", "CILINDRICO 14GL", "CILINDRICO 17GL", "CILINDRICO 19GL", 
        //                                                      "LENTEJA 4.5GL", "LENTEJA 5.5GL", "LENTEJA 7GL", "TOROIDAL 6.5GL 0°", "TOROIDAL 6.5GL 30°",
        //                                                      "TOROIDAL 9GL 0°", "TOROIDAL 9GL 30°", "TOROIDAL 10GL 0°", "TOROIDAL 10GL 30°", "TOROIDAL 12GL 0°",
        //                                                      "TOROIDAL 12GL 30°","TOROIDAL 15GL 0°", "TOROIDAL 15GL 30°"};
        //public static string[] ArrayListGNV = new string[10] { "1 CILINDRO 2GL", "1 CILINDRO 3GL", "1 CILINDRO 4GL", "1 CILINDRO 5GL",
        //                                                       "1 CILINDRO 5.5GL", "2 CILINDROS 2GL", "2 CILINDROS 3GL", "2 CILINDROS 4GL",
        //                                                       "1 CIL. 3GL + 1 CIL. 2GL", "1 CIL. 4GL + 1 CIL. 3GL"};
        //public static string[] ArrayListPeriodico = new string[2] { "Trome", "Ojo" };


        public static string[] ArrayListCilMotor3 = new string[3] { "800", "900", "1000" };
        public static string[] ArrayListCilMotor4 = new string[13] { "900", "1000", "1200", "1300", "1400", "1500", "1600", 
                                                        "1800", "2000", "2200", "2400", "2700", "2800"};
        public static string[] ArrayListCilMotor6 = new string[5] { "2800", "3000", "3500", "3700", "4000" };
        public static string[] ArrayListCilMotor8 = new string[3] { "4000", "4700", "5200" };
        public static string[] ArrayListGLP = new string[21] {"CILINDRICO 6.5GL","CILINDRICO 7.5GL", "CILINDRICO 9GL", "CILINDRICO 10.5GL",
                                                              "CILINDRICO 12.5GL", "CILINDRICO 14GL", "CILINDRICO 17GL", "CILINDRICO 19GL", 
                                                              "LENTEJA 4.5GL", "LENTEJA 5.5GL", "LENTEJA 7GL", "TOROIDAL 6.5GL 0°", "TOROIDAL 6.5GL 30°",
                                                              "TOROIDAL 9GL 0°", "TOROIDAL 9GL 30°", "TOROIDAL 10GL 0°", "TOROIDAL 10GL 30°", "TOROIDAL 12GL 0°",
                                                              "TOROIDAL 12GL 30°","TOROIDAL 15GL 0°", "TOROIDAL 15GL 30°"};
        public static string[] ArrayListGNV = new string[10] { "1 CILINDRO 2GL", "1 CILINDRO 3GL", "1 CILINDRO 4GL", "1 CILINDRO 5GL",
                                                               "1 CILINDRO 5.5GL", "2 CILINDROS 2GL", "2 CILINDROS 3GL", "2 CILINDROS 4GL",
                                                               "1 CIL. 3GL + 1 CIL. 2GL", "1 CIL. 4GL + 1 CIL. 3GL"};
        public static string[] ArrayListPeriodico = new string[2] { "Trome", "Ojo" };

        #endregion

        #region ComboBoxes de Actividad
        public static class ACTIVIDAD
        {
            public static class COMBO_BOX
            {
                public static Array Actividades = new[] { 
                    new { Text = "Llamada telefónica", Value = "0" }, 
                    new { Text = "Reunión", Value = "1" } 
                    //new { Text = "Tarea", Value = "2" },
                    //new { Text = "Nota", Value = "4" },
                    //new { Text = "Campaña", Value = "5" },
                    //new { Text = "Otros", Value = "3" }
                };

                public static Array Prioridades = new[] { 
                    new { Text = "Bajo", Value = "0" }, 
                    new { Text = "Normal", Value = "1" }, 
                    new { Text = "Alto", Value = "2" }
                };

                public static Array Repeticiones = new[] { 
                    new { Text = "Ninguno", Value = "0" }, 
                    new { Text = "Diario", Value = "1" }, 
                    new { Text = "Semanal", Value = "2" },
                    new { Text = "Mensual", Value = "3" },
                    new { Text = "Anual", Value = "4" }
                };
            }
        }

        #endregion

        #region ValoresConstantes
        public static class OFFER
        {
            public static class TIPO_COMBUSTIBLE
            {
                public static string GNV = "V";
                public static string GLP = "P";
            }

            public static class UBICACION_TANQUE
            {
                public static string ARRIBA = "A";
                public static string ABAJO = "O";
            }

            public static class USO_VEHICULO
            {
                public static string TAXI = "T";
                public static string PARTICULAR = "P";
            }
        }

        #endregion

    }
}
