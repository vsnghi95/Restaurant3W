using BussinessObject2;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmManagement
{
    public partial class StaffForm : Form
    {
        IFoodRepository _foodRepository;
        IOrderDetailRepository _orderDetailRepository;
        IPayment _payment;
        IReservationRepository _reservationRepository;
        IOrderRepository _orderRepository;
        ICustomerRepository _customerRepository;

        private int LastCreatedOrderId;
        public StaffForm()
        {
            InitializeComponent();
            _orderDetailRepository = new OrderDetailRepository();
            _foodRepository = new FoodRepository();
            _payment = new PaymentRepository();
            _reservationRepository = new ReservationRepository();
            _orderRepository = new OrderRepository();
            _customerRepository = new CustomerRepository();

            txtStatus.Enabled = false;
            txtStatus2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrderDetail order = new OrderDetail();

            var fid = int.Parse(cbbFood.SelectedValue.ToString());
            var quantity = int.Parse(txtQuantity.Text);

            order.Oid = LastCreatedOrderId;
            order.Fid = fid;
            order.Quantity = quantity;
            order.AmountOfFood = (_foodRepository.GetFoodByFid(fid).Price) * quantity;

            _orderDetailRepository.AddOrderDetail(order);

            var listOrderDetail = _orderDetailRepository.GetOrderDetails().Where(x => x.Oid == LastCreatedOrderId);
            dgvFood.DataSource = new BindingSource() { DataSource = listOrderDetail };

            txtStatus2.Text = "Add Food Successfully";
        }

        private void btnComfirm_Click(object sender, EventArgs e)
        {
            txtEmail.Text = string.Empty;
            txtName.Text = string.Empty;
            txtNumG.Text = string.Empty;
            txtPhone.Text= string.Empty;
            txtPrepay.Text = string.Empty;
            txtStatus.Text = "Status";
            txtStatus2.Text = "Done Booking";
            txtQuantity.Text = string.Empty;

            btnReverse.Enabled = true;
        }

        private void StaffForm_Load(object sender, EventArgs e)
        {
            var cbb = _foodRepository.GetFoods().ToArray();
            var cbb2 = _payment.GetDepositCates().ToArray();

            cbbPrepay.DataSource = new BindingSource { DataSource = cbb2 };
            cbbPrepay.DisplayMember = "DepositName";
            cbbPrepay.ValueMember = "DepositId";
            cbbPrepay.SelectedIndex = 0;

            cbbFood.DataSource = new BindingSource { DataSource = cbb };
            cbbFood.DisplayMember = "Fname";
            cbbFood.ValueMember = "Fid";
            cbbFood.SelectedIndex = 0;

        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            try
            {
                Reservation reservation = new Reservation();
                Order order = new Order();
                Customer customer = new Customer();

                customer.CustomerName = txtName.Text;
                customer.Phone = txtPhone.Text;
                customer.Email = txtEmail.Text;

                _customerRepository.AddCustomer(customer);

                reservation.Aid = 2;
                reservation.Cid = customer.Cid;
                reservation.ResDate = dateTimePicker1.Value;
                reservation.NumGuest = int.Parse(txtNumG.Text);
                reservation.DepositType = int.Parse(cbbPrepay.SelectedValue.ToString());
                reservation.DepositValue = decimal.Parse(txtPrepay.Text);

                _reservationRepository.AddReservation(reservation);

                order.OrderDate = dateTimePicker1.Value;
                order.NumGuest = int.Parse(txtNumG.Text);
                order.Rid = reservation.Rid;

                _orderRepository.AddOrder(order);

                reservation.Oid = order.Oid;

                _reservationRepository.UpdateReservation(reservation);

                LastCreatedOrderId = int.Parse(order.Oid.ToString());

                btnReverse.Enabled = false;

                txtStatus.Text = "Successfully Add";
            } catch (Exception ex)
            {
                MessageBox.Show("There something Wrong", "Error");
            }
        }
    }
}
