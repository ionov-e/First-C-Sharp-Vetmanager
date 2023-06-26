using FirstCSharp.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstCSharp.WindowsForm
{
    public partial class PetForm : Form
    {
        private readonly VetmanagerApiGateway _vetmanagerApiGateway;
        private readonly Pet? _pet;

        public PetForm(VetmanagerApiGateway vetmanagerApiGateway)
        {
            InitializeComponent();
            _vetmanagerApiGateway = vetmanagerApiGateway;
        }

        public PetForm(VetmanagerApiGateway vetmanagerApiGateway, Pet pet)
        {
            InitializeComponent();
            _vetmanagerApiGateway = vetmanagerApiGateway;
            _pet = pet;
        }
    }
}
