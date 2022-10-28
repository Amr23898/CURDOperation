using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace _3layerCrudOperation
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            dgvtop.DataSource = coursebussinesslayer.getalldata();
            combo_top.DataSource = topicbussinesslayer.getalldata();
            combo_top.DisplayMember = "top_name";
            combo_top.ValueMember = "top_id";
            bt_update.Visible = false;




        }
       private void btn_ins_Click(object sender, EventArgs e)
        {

            int result = coursebussinesslayer.InserData(int.Parse(text_id.Text), text_name.Text, int.Parse(text_duration.Text), int.Parse(combo_top.SelectedValue.ToString()));
            if(result > 0)
            {
                text_duration.Text = text_name.Text = text_id.Text = "";
                lb_state.Text = "Inserted Successfully";
                dgvtop.DataSource = coursebussinesslayer.getalldata();
            }
        }
        private void dgvtop_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            text_id.Text = dgvtop.SelectedRows[0].Cells[0].Value.ToString();
            text_name.Text = dgvtop.SelectedRows[0].Cells[1].Value.ToString();
            text_duration.Text = dgvtop.SelectedRows[0].Cells[2].Value.ToString();
            combo_top.Text = dgvtop.SelectedRows[0].Cells[3].Value.ToString();
            text_id.Enabled = false;
            bt_update.Visible = true;
            btn_ins.Enabled = false;
        }
        private void bt_update_Click(object sender, EventArgs e)
        {
            int result = coursebussinesslayer.UpdateData(int.Parse(text_id.Text), text_name.Text, int.Parse(text_duration.Text), int.Parse(combo_top.SelectedValue.ToString()));
            if (result > 0)
            {
                text_duration.Text = text_name.Text = text_id.Text = "";
                lb_state.Text = "Updated Successfully";
                dgvtop.DataSource = coursebussinesslayer.getalldata();
                text_id.Enabled = true;
                btn_ins.Enabled = true;

                bt_update.Visible = false;
            }
        }
        //Deleted by click yes on message box
        private void dgvtop_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if((MessageBox.Show("Are you sure to delete yhis row ?", "confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)){
                int id = (int)dgvtop.SelectedRows[0].Cells[0].Value;
              int result=  coursebussinesslayer.DeleteData(id);
                if (result > 0)
                {
                    lb_state.Text = "Deleted Successfully";
                    dgvtop.DataSource = coursebussinesslayer.getalldata();
                }

            }

        }
        //Deleted by Insert Id You need Deleted 
        private void btn_delete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(text_id.Text);
            int result = coursebussinesslayer.DeleteData(id);
            if (result > 0)
            {
                lb_state.Text = "Deleted Successfully";
                dgvtop.DataSource = coursebussinesslayer.getalldata();
            }

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            int id = int.Parse(text_id.Text);
            dgvtop.DataSource=coursebussinesslayer.search(id);
        }
    }
}