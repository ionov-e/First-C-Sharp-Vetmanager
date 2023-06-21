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

namespace FirstCSharp
{
    public partial class UserList : Form
    {
        private readonly Client[] _clients;

        public UserList(Client[] clients)
        {
            InitializeComponent();
            _clients = clients;
            comboBoxUserList.DataSource = _clients;
            comboBoxUserList.DisplayMember = "FullName";
            comboBoxUserList.ValueMember = "Id";
        }
    }
}
