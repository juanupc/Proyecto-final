namespace CapaPresentacion
{
    partial class Inicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menu = new System.Windows.Forms.MenuStrip();
            this.MenuUsuario = new FontAwesome.Sharp.IconMenuItem();
            this.MenuMantenedor = new FontAwesome.Sharp.IconMenuItem();
            this.Submenucategoria = new FontAwesome.Sharp.IconMenuItem();
            this.Submenuproducto = new FontAwesome.Sharp.IconMenuItem();
            this.MenuVentas = new FontAwesome.Sharp.IconMenuItem();
            this.Submenuregistrarventas = new FontAwesome.Sharp.IconMenuItem();
            this.Submenuverdetalleventas = new FontAwesome.Sharp.IconMenuItem();
            this.MenuCompras = new FontAwesome.Sharp.IconMenuItem();
            this.submenuregistrarcompras = new FontAwesome.Sharp.IconMenuItem();
            this.Submenuverdetallercompras = new FontAwesome.Sharp.IconMenuItem();
            this.MenuClientes = new FontAwesome.Sharp.IconMenuItem();
            this.MenuProveedores = new FontAwesome.Sharp.IconMenuItem();
            this.MenuReportes = new FontAwesome.Sharp.IconMenuItem();
            this.MenuAcercaDe = new FontAwesome.Sharp.IconMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.Contenedor = new System.Windows.Forms.Panel();
            this.Usuario = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuUsuario,
            this.MenuMantenedor,
            this.MenuVentas,
            this.MenuCompras,
            this.MenuClientes,
            this.MenuProveedores,
            this.MenuReportes,
            this.MenuAcercaDe});
            this.menu.Location = new System.Drawing.Point(0, 56);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1123, 73);
            this.menu.TabIndex = 0;
            this.menu.Text = "menu";
            // 
            // MenuUsuario
            // 
            this.MenuUsuario.AutoSize = false;
            this.MenuUsuario.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            this.MenuUsuario.IconColor = System.Drawing.Color.Black;
            this.MenuUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuUsuario.IconSize = 50;
            this.MenuUsuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuUsuario.Name = "MenuUsuario";
            this.MenuUsuario.Size = new System.Drawing.Size(80, 69);
            this.MenuUsuario.Text = "Usuario";
            this.MenuUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MenuUsuario.Click += new System.EventHandler(this.MenuUsuario_Click_1);
            // 
            // MenuMantenedor
            // 
            this.MenuMantenedor.AutoSize = false;
            this.MenuMantenedor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Submenucategoria,
            this.Submenuproducto});
            this.MenuMantenedor.IconChar = FontAwesome.Sharp.IconChar.ScrewdriverWrench;
            this.MenuMantenedor.IconColor = System.Drawing.Color.Black;
            this.MenuMantenedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuMantenedor.IconSize = 50;
            this.MenuMantenedor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuMantenedor.Name = "MenuMantenedor";
            this.MenuMantenedor.Size = new System.Drawing.Size(80, 69);
            this.MenuMantenedor.Text = "Mantenedor";
            this.MenuMantenedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // Submenucategoria
            // 
            this.Submenucategoria.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Submenucategoria.IconColor = System.Drawing.Color.Black;
            this.Submenucategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Submenucategoria.Name = "Submenucategoria";
            this.Submenucategoria.Size = new System.Drawing.Size(125, 22);
            this.Submenucategoria.Text = "Categoria";
            this.Submenucategoria.Click += new System.EventHandler(this.Submenucategoria_Click);
            // 
            // Submenuproducto
            // 
            this.Submenuproducto.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Submenuproducto.IconColor = System.Drawing.Color.Black;
            this.Submenuproducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Submenuproducto.Name = "Submenuproducto";
            this.Submenuproducto.Size = new System.Drawing.Size(125, 22);
            this.Submenuproducto.Text = "Producto";
            this.Submenuproducto.Click += new System.EventHandler(this.Submenuproducto_Click);
            // 
            // MenuVentas
            // 
            this.MenuVentas.AutoSize = false;
            this.MenuVentas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Submenuregistrarventas,
            this.Submenuverdetalleventas});
            this.MenuVentas.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.MenuVentas.IconColor = System.Drawing.Color.Black;
            this.MenuVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuVentas.IconSize = 50;
            this.MenuVentas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuVentas.Name = "MenuVentas";
            this.MenuVentas.Size = new System.Drawing.Size(80, 69);
            this.MenuVentas.Text = "Ventas";
            this.MenuVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // Submenuregistrarventas
            // 
            this.Submenuregistrarventas.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Submenuregistrarventas.IconColor = System.Drawing.Color.Black;
            this.Submenuregistrarventas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Submenuregistrarventas.Name = "Submenuregistrarventas";
            this.Submenuregistrarventas.Size = new System.Drawing.Size(129, 22);
            this.Submenuregistrarventas.Text = "Registrar";
            this.Submenuregistrarventas.Click += new System.EventHandler(this.Submenuregistrarventas_Click);
            // 
            // Submenuverdetalleventas
            // 
            this.Submenuverdetalleventas.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Submenuverdetalleventas.IconColor = System.Drawing.Color.Black;
            this.Submenuverdetalleventas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Submenuverdetalleventas.Name = "Submenuverdetalleventas";
            this.Submenuverdetalleventas.Size = new System.Drawing.Size(129, 22);
            this.Submenuverdetalleventas.Text = "Ver Detalle";
            this.Submenuverdetalleventas.Click += new System.EventHandler(this.Submenuverdetalleventas_Click);
            // 
            // MenuCompras
            // 
            this.MenuCompras.AutoSize = false;
            this.MenuCompras.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenuregistrarcompras,
            this.Submenuverdetallercompras});
            this.MenuCompras.IconChar = FontAwesome.Sharp.IconChar.CartFlatbed;
            this.MenuCompras.IconColor = System.Drawing.Color.Black;
            this.MenuCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuCompras.IconSize = 50;
            this.MenuCompras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuCompras.Name = "MenuCompras";
            this.MenuCompras.Size = new System.Drawing.Size(80, 69);
            this.MenuCompras.Text = "Compras";
            this.MenuCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // submenuregistrarcompras
            // 
            this.submenuregistrarcompras.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuregistrarcompras.IconColor = System.Drawing.Color.Black;
            this.submenuregistrarcompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuregistrarcompras.Name = "submenuregistrarcompras";
            this.submenuregistrarcompras.Size = new System.Drawing.Size(129, 22);
            this.submenuregistrarcompras.Text = "Registrar";
            this.submenuregistrarcompras.Click += new System.EventHandler(this.submenuregistrarcompras_Click);
            // 
            // Submenuverdetallercompras
            // 
            this.Submenuverdetallercompras.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Submenuverdetallercompras.IconColor = System.Drawing.Color.Black;
            this.Submenuverdetallercompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Submenuverdetallercompras.Name = "Submenuverdetallercompras";
            this.Submenuverdetallercompras.Size = new System.Drawing.Size(129, 22);
            this.Submenuverdetallercompras.Text = "Ver Detalle";
            this.Submenuverdetallercompras.Click += new System.EventHandler(this.Submenuverdetallercompras_Click);
            // 
            // MenuClientes
            // 
            this.MenuClientes.AutoSize = false;
            this.MenuClientes.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.MenuClientes.IconColor = System.Drawing.Color.Black;
            this.MenuClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuClientes.IconSize = 50;
            this.MenuClientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuClientes.Name = "MenuClientes";
            this.MenuClientes.Size = new System.Drawing.Size(80, 69);
            this.MenuClientes.Text = "Clientes";
            this.MenuClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MenuClientes.Click += new System.EventHandler(this.MenuClientes_Click_1);
            // 
            // MenuProveedores
            // 
            this.MenuProveedores.AutoSize = false;
            this.MenuProveedores.IconChar = FontAwesome.Sharp.IconChar.Vcard;
            this.MenuProveedores.IconColor = System.Drawing.Color.Black;
            this.MenuProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuProveedores.IconSize = 50;
            this.MenuProveedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuProveedores.Name = "MenuProveedores";
            this.MenuProveedores.Size = new System.Drawing.Size(80, 69);
            this.MenuProveedores.Text = "Proveedores";
            this.MenuProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MenuProveedores.Click += new System.EventHandler(this.MenuProveedores_Click);
            // 
            // MenuReportes
            // 
            this.MenuReportes.AutoSize = false;
            this.MenuReportes.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            this.MenuReportes.IconColor = System.Drawing.Color.Black;
            this.MenuReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuReportes.IconSize = 50;
            this.MenuReportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuReportes.Name = "MenuReportes";
            this.MenuReportes.Size = new System.Drawing.Size(80, 69);
            this.MenuReportes.Text = "Reportes";
            this.MenuReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MenuReportes.Click += new System.EventHandler(this.MenuReportes_Click);
            // 
            // MenuAcercaDe
            // 
            this.MenuAcercaDe.AutoSize = false;
            this.MenuAcercaDe.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.MenuAcercaDe.IconColor = System.Drawing.Color.Black;
            this.MenuAcercaDe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuAcercaDe.IconSize = 50;
            this.MenuAcercaDe.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuAcercaDe.Name = "MenuAcercaDe";
            this.MenuAcercaDe.Size = new System.Drawing.Size(80, 69);
            this.MenuAcercaDe.Text = "Acerca de";
            this.MenuAcercaDe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuStrip2
            // 
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip2.Size = new System.Drawing.Size(1123, 56);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menutitulo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sistema de Ventas";
            // 
            // Contenedor
            // 
            this.Contenedor.BackColor = System.Drawing.SystemColors.Control;
            this.Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contenedor.Location = new System.Drawing.Point(0, 129);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.Size = new System.Drawing.Size(1123, 518);
            this.Contenedor.TabIndex = 3;
            // 
            // Usuario
            // 
            this.Usuario.AutoSize = true;
            this.Usuario.BackColor = System.Drawing.SystemColors.Highlight;
            this.Usuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Usuario.Location = new System.Drawing.Point(977, 30);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(46, 13);
            this.Usuario.TabIndex = 4;
            this.Usuario.Text = "Usuario:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUsuario.Location = new System.Drawing.Point(1023, 31);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(53, 13);
            this.lblUsuario.TabIndex = 5;
            this.lblUsuario.Text = "lblUsuario";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 647);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.Contenedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menu;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Contenedor;
        private System.Windows.Forms.Label Usuario;
        private System.Windows.Forms.Label lblUsuario;
        private FontAwesome.Sharp.IconMenuItem MenuMantenedor;
        private FontAwesome.Sharp.IconMenuItem MenuVentas;
        private FontAwesome.Sharp.IconMenuItem MenuCompras;
        private FontAwesome.Sharp.IconMenuItem MenuUsuario;
        private FontAwesome.Sharp.IconMenuItem MenuProveedores;
        private FontAwesome.Sharp.IconMenuItem MenuReportes;
        private FontAwesome.Sharp.IconMenuItem Submenucategoria;
        private FontAwesome.Sharp.IconMenuItem Submenuproducto;
        private FontAwesome.Sharp.IconMenuItem Submenuregistrarventas;
        private FontAwesome.Sharp.IconMenuItem Submenuverdetalleventas;
        private FontAwesome.Sharp.IconMenuItem submenuregistrarcompras;
        private FontAwesome.Sharp.IconMenuItem Submenuverdetallercompras;
        private FontAwesome.Sharp.IconMenuItem MenuClientes;
        private FontAwesome.Sharp.IconMenuItem MenuAcercaDe;
    }
}