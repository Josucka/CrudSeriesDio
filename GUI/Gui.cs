using System;

namespace OrientacaoObjto.GUI
{
    class Gui
    {
        public static String Title(String str)
        {
            str = String.Format("==== {0} ====", str);

            return str;
        }

        public static String MenuTitle(int index, String str)
        {
            str = String.Format(" - ({0}) - :", index, str);

            return str;
        }

        public static String MenuOption(int index, String str)
        {
            str = String.Format(" - ({0}) {1} - :", index, str);

            return str;
        }
    }
}
