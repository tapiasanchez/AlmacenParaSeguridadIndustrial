﻿using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormProducto : Form
    {
        private Producto producto = new Producto();
        public CN_Producto cn_Producto = new CN_Producto();
        public FormProducto()
        {
            InitializeComponent();
        }

        private void FormProducto_Load(object sender, EventArgs e)
        {
            dtpRegistro.Value = DateTime.Now;
            dtpRegistro.Format = DateTimePickerFormat.Custom;
            dtpRegistro.CustomFormat = "dd/MM/yyyy hh:mm";
            loadComboBoxTalla();
            cargarDGVProducto();
        }

        private void loadComboBoxTalla()
        {
            List<Talla> tallas = new CN_Talla().Listar();
            foreach (Talla talla in tallas)
            {
                comboBoxTalla.Items.Add(new OpcionCombo()
                {
                    Texto = talla.Nombre,
                    Valor = talla.IdTalla
                });
                comboBoxTalla.DisplayMember = "Texto";
                comboBoxTalla.ValueMember = "Valor";
                comboBoxTalla.SelectedIndex = 0;
            }
        }
        private void cargarDGVProducto()
        {
            dgvProducto.Rows.Clear();
            List<Producto> listaProducto = cn_Producto.Listar();
            foreach (Producto item in listaProducto)
            {
                dgvProducto.Rows.Add(item.Codigo, item.NombreProducto, item.Descripcion, item.Cantidad, item.Talla.Nombre);
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            producto.Codigo = textCodigo.Text;
            producto.NombreProducto = textProducto.Text;
            producto.Descripcion = textDescripcion.Text;
            producto.Cantidad = Convert.ToInt32(textCantidad.Text);
            producto.Talla = new Talla() { IdTalla = Convert.ToInt32(((OpcionCombo)comboBoxTalla.SelectedItem).Valor) };
            producto.Fecha = dtpRegistro.Value;
            cn_Producto.Registrar(producto);
            cargarDGVProducto();
            limpiarText();
        }
        private void limpiarText()
        {
            textCodigo.Text = "";
            textProducto.Text = "";
            textDescripcion.Text = "";
            textCantidad.Text = "";
        }
    }
}
