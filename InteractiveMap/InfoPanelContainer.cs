using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveMap
{
    class InfoPanelContainer
    {
        public string header;
        public string mainText;
        public Image image;
        public int id;
        public int markerType;

        public InfoPanelContainer(string header, string mainText, Image image)
        {
            this.header = header;
            this.mainText = mainText;
            this.image = image;
            this.id = 0;
            this.markerType = 0;
        }

        public InfoPanelContainer(int id, int markerType, string header, string mainText, Image image)
        {
            this.header = header;
            this.mainText = mainText;
            this.image = image;
            this.id = id;
            this.markerType = markerType;
        }
    }
}
