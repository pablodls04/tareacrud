﻿using CapaEntidad;
using CapaNegocio;
using System.Windows.Forms;
using System;

private void btnInsertar_Click(object sender, EventArgs e)
{
    Contacto nuevoContacto = new Contacto
    {
        Nombre = txtNombre.Text,
        Telefono = txtTelefono.Text,
        Email = txtEmail.Text,
        Direccion = txtDireccion.Text
    };

    try
    {
        ContactoBL contactoBL = new ContactoBL();
        contactoBL.Insertar(nuevoContacto);
        MessageBox.Show("Contacto insertado correctamente.");
        LimpiarCampos();     // Limpia los campos luego de insertar
        CargarContactos();   // Actualiza la lista de contactos en el DataGridView
    }
    catch (Exception ex)
    {
        MessageBox.Show("Error al insertar el contacto: " + ex.Message);
        MessageBox.Show("Contacto insertado correctamente .");

    }
}

private void LimpiarCampos()
{
    txtId.Clear();
    txtNombre.Clear();
    txtTelefono.Clear();
    txtEmail.Clear();
    txtDireccion.Clear();
}
