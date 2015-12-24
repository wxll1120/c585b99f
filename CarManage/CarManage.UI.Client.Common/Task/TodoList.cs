﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ClassLibrary.ExceptionHandling;
using ClassLibrary.Utility.Common;
using ClassLibrary.Utility.Form;
using CarManage.Configuration;
using ClassLibrary.Winform.UI.Controls;
using CarManage.Resources.Common;

namespace CarManage.UI.Client.Common.Task
{
    public partial class TodoList : UserControlBase
    {
        public TodoList()
        {
            InitializeComponent();
            InitControl();
        }

        #region 公共属性

        /// <summary>
        /// 客户主键
        /// </summary>
        public string CustomerId { get; set; }

        /// <summary>
        /// 车辆主键
        /// </summary>
        public string CarId { get; set; }

        /// <summary>
        /// 招揽主键
        /// </summary>
        public string SolicitId { get; set; }

        #endregion

        #region 私有变量

        CarManage.Business.Customer.Car car;
        CarManage.Business.Customer.Customer customer;
        CarManage.Business.Solicit.Solicit solicit;

        #endregion

        private void InitControl()
        {
            dgvList.ColumnHeaderBackgroundImage = ImageResource.List_Header_Lower_BG;
            dgvList.AutoGenerateColumns = false;
        }

        protected override void Init()
        {
            car = new Business.Customer.Car();
            customer = new Business.Customer.Customer();
            solicit = new Business.Solicit.Solicit();

            base.Init();
        }

        private void TodoList_Load(object sender, EventArgs e)
        {
            btnSearch_Click(null, null);//载入即执行无条件查询
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {

        }

    }
}
