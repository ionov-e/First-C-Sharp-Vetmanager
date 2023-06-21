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
        private readonly ClientListData _clientListData;

        public UserList()
        {
            InitializeComponent();
        }

        private void comboBoxUserList_Load(object sender, EventArgs e)
        {
            comboBoxUserList.DataSource = _clientListData.Clients;
            comboBoxUserList.DisplayMember = "LastName";
        }
    }
}
