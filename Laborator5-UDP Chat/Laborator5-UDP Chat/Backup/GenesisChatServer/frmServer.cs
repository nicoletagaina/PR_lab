/*
 * Genesis Socket Server and Client
 * (C)Copyright 2005/2006 Robert Harwood <robharwood@runbox.com>
 * 
 * Please see included license.txt file for information on redistribution and usage.
 */
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using GenesisCore;

namespace GenesisChatServer
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class frmServer : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtPort;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cmbIP;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Button btnStop;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.StatusBar sbStatusBar;
		private System.Windows.Forms.StatusBarPanel spState;
		private System.Windows.Forms.NotifyIcon nIcon;
		private System.Windows.Forms.Button btnHide;

		private GenesisCore.IGenesisUDP m_UDP;

		public frmServer()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//Instantiate the genesis core
			m_UDP = GenesisCore.InterfaceFactory.CreateGenesisUDP("ChatServer");
			spState.Text = "Started Genesis Core engine.";
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmServer));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnStop = new System.Windows.Forms.Button();
			this.btnStart = new System.Windows.Forms.Button();
			this.txtPort = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cmbIP = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.sbStatusBar = new System.Windows.Forms.StatusBar();
			this.spState = new System.Windows.Forms.StatusBarPanel();
			this.nIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.btnHide = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.spState)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnHide);
			this.groupBox1.Controls.Add(this.txtPassword);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.btnStop);
			this.groupBox1.Controls.Add(this.btnStart);
			this.groupBox1.Controls.Add(this.txtPort);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.cmbIP);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(8, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(400, 120);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Server Settings";
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(8, 88);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(144, 21);
			this.txtPassword.TabIndex = 12;
			this.txtPassword.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 72);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 16);
			this.label3.TabIndex = 11;
			this.label3.Text = "Password";
			// 
			// btnStop
			// 
			this.btnStop.Enabled = false;
			this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnStop.Location = new System.Drawing.Point(264, 56);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new System.Drawing.Size(120, 24);
			this.btnStop.TabIndex = 10;
			this.btnStop.Text = "Stop Server";
			this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
			// 
			// btnStart
			// 
			this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnStart.Location = new System.Drawing.Point(264, 24);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(120, 24);
			this.btnStart.TabIndex = 9;
			this.btnStart.Text = "Start Server";
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// txtPort
			// 
			this.txtPort.Location = new System.Drawing.Point(168, 40);
			this.txtPort.Name = "txtPort";
			this.txtPort.Size = new System.Drawing.Size(72, 21);
			this.txtPort.TabIndex = 8;
			this.txtPort.Text = "27000";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(168, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 16);
			this.label2.TabIndex = 7;
			this.label2.Text = "Port";
			// 
			// cmbIP
			// 
			this.cmbIP.Location = new System.Drawing.Point(8, 40);
			this.cmbIP.Name = "cmbIP";
			this.cmbIP.Size = new System.Drawing.Size(144, 21);
			this.cmbIP.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(144, 16);
			this.label1.TabIndex = 5;
			this.label1.Text = "IP Address";
			// 
			// sbStatusBar
			// 
			this.sbStatusBar.Location = new System.Drawing.Point(0, 135);
			this.sbStatusBar.Name = "sbStatusBar";
			this.sbStatusBar.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
																						   this.spState});
			this.sbStatusBar.ShowPanels = true;
			this.sbStatusBar.Size = new System.Drawing.Size(418, 24);
			this.sbStatusBar.SizingGrip = false;
			this.sbStatusBar.TabIndex = 6;
			// 
			// spState
			// 
			this.spState.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
			this.spState.Text = "Application started.";
			this.spState.Width = 418;
			// 
			// nIcon
			// 
			this.nIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("nIcon.Icon")));
			this.nIcon.Text = "Genesis Chat Server";
			this.nIcon.Visible = true;
			this.nIcon.DoubleClick += new System.EventHandler(this.nIcon_DoubleClick);
			// 
			// btnHide
			// 
			this.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnHide.Location = new System.Drawing.Point(264, 88);
			this.btnHide.Name = "btnHide";
			this.btnHide.Size = new System.Drawing.Size(120, 24);
			this.btnHide.TabIndex = 13;
			this.btnHide.Text = "Hide Server";
			this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
			// 
			// frmServer
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.ClientSize = new System.Drawing.Size(418, 159);
			this.Controls.Add(this.sbStatusBar);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmServer";
			this.Text = "Genesis Chat Server";
			this.Load += new System.EventHandler(this.frmServer_Load);
			this.Closed += new System.EventHandler(this.frmServer_Closed);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.spState)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.EnableVisualStyles( );
			Application.DoEvents( );
			Application.Run(new frmServer());
		}

		/// <summary>
		/// Server was loaded.
		/// </summary>
		private void frmServer_Load(object sender, System.EventArgs e)
		{
			string[] addresses = m_UDP.GetLocalAddresses( );
			cmbIP.Items.Clear( );
			if(addresses.Length > 0)
			{
				for(int i = 0; i < addresses.Length; i++)
					cmbIP.Items.Add(addresses[i]);

				cmbIP.Text = (string)cmbIP.Items[0];
			}

			//Hook genesis core events
			m_UDP.OnListenStateChanged += new ListenHandler(m_UDP_OnListenStateChanged);
			m_UDP.OnConnectionAuth += new ConnectionAuthHandler(m_UDP_OnConnectionAuth);
			m_UDP.OnCommandReceived += new IncomingCommandHandler(m_UDP_OnCommandReceived);
			m_UDP.OnConnectionStateChanged += new ConnectionStateChangeHandler(m_UDP_OnConnectionStateChanged);
		}

		/// <summary>
		/// Server was shut down.
		/// </summary>
		private void frmServer_Closed(object sender, System.EventArgs e)
		{
			m_UDP.StopListen( );

			//Unhook events
			m_UDP.OnListenStateChanged -= new ListenHandler(m_UDP_OnListenStateChanged);
			m_UDP.OnConnectionAuth -= new ConnectionAuthHandler(m_UDP_OnConnectionAuth);
			m_UDP.OnCommandReceived -= new IncomingCommandHandler(m_UDP_OnCommandReceived);
			m_UDP.OnConnectionStateChanged -= new ConnectionStateChangeHandler(m_UDP_OnConnectionStateChanged);
		}

		#region Event Handling
		/// <summary>
		/// The UDP engine has started or stopped listening.
		/// </summary>
		private void m_UDP_OnListenStateChanged(object o, ListenEventArgs e) { this.Invoke(new GenesisCore.ListenHandler(OnListenStateChanged), new object[] {o,e}); }

		private void OnListenStateChanged(object o, ListenEventArgs e)
		{
			btnStart.Enabled = (!e.Listening);
			btnStop.Enabled = e.Listening;

			if(e.Listening)
				spState.Text = "Server started.";
			else
				spState.Text = "Server stopped.";
		}

		/// <summary>
		/// Client has sent login information
		/// </summary>
		private void m_UDP_OnConnectionAuth(object o, ConnectionAuthEventArgs e) { this.Invoke(new GenesisCore.ConnectionAuthHandler(OnConnectionAuth), new object[] {o, e}); }
		private void OnConnectionAuth(object o, ConnectionAuthEventArgs e)
		{
            //The chat login packet fields are : (Field 0 = Server PW, Field 1 = User nickname).

			if(e.AuthCommand.Fields.Length < 2)
			{
				e.AllowConnection = false;
				e.DisallowReason = "No nickname sent.";
				return;
			}
			else
			{
				if(e.AuthCommand.Fields[1].Length < 3)
				{
					e.AllowConnection = false;
					e.DisallowReason = "Nickname too short.";
					return;
				}
				else if(e.AuthCommand.Fields[1].Length > 15)
				{
					e.AllowConnection = false;
					e.DisallowReason = "Nickname too long.";
					return;
				}
				else
				{
					if(e.AuthCommand.Fields[0] == txtPassword.Text)
					{
						e.AllowConnection = true;

						//Store the users nickname on the connection
						UserData ud = new UserData( );
						ud.NickName = e.AuthCommand.Fields[1];
						e.ClientConnection.UserObject = ud;

						//Send the connected packet
						m_UDP.SendReliableCommandToAll(BroadcastFilter.Clients | BroadcastFilter.AuthedOnly, 0, "22", new string[] {ud.NickName, "1"});

						//Send the user list to currently connected users
						SendUserList(null);
					}
					else
					{
						e.AllowConnection = false;
						e.DisallowReason = "Bad password.";
					}
				}
			}
		}

		/// <summary>
		/// Have got an incoming connection from a connected client.
		/// </summary>
		private void m_UDP_OnCommandReceived(object o, CommandEventArgs e) { this.Invoke(new GenesisCore.IncomingCommandHandler(OnCommandReceived), new object[] {o, e}); }
		private void OnCommandReceived(object o, CommandEventArgs e)
		{
			//Chat packet
			if(e.SentCommand.OPCode == "20")
			{
				//Get the user data object
				UserData ud = e.Sender.UserObject as UserData;
				if(ud == null)
					return; //Should never happen

				m_UDP.SendUnreliableCommandToAll(BroadcastFilter.Clients | BroadcastFilter.AuthedOnly, GenesisConsts.FLAGS_SEQUENCED, "21", new string[] {ud.NickName, e.SentCommand.Fields[0]});
			}

			//Request for the user list.
			if(e.SentCommand.OPCode == "23")
			{
				SendUserList(e.Sender);
			}
		}

		/// <summary>
		/// A connection has come or gone
		/// </summary>
		private void m_UDP_OnConnectionStateChanged(object o, ConnectionStateChangeEventArgs e)	{ this.Invoke(new GenesisCore.ConnectionStateChangeHandler(OnConnectionStateChanged), new object[] {o, e} ); }
		private void OnConnectionStateChanged(object o, ConnectionStateChangeEventArgs e)
		{
			if(!e.Connected)
			{
				if(e.Connection.UserObject != null)
				{
					UserData ud = new UserData( );
					ud = e.Connection.UserObject as UserData;

					if(ud != null)
					{
						//Send the disconnected packet
						m_UDP.SendReliableCommandToAll(BroadcastFilter.Clients | BroadcastFilter.AuthedOnly, 0, "22", new string[] {ud.NickName, "0"});

						SendUserList(null);
					}
				}
			}
		}
		#endregion

		/// <summary>
		/// Sends a user list to one or all clients.
		/// </summary>
		private void SendUserList(IConnection conn)
		{
			GenesisCore.IConnection[] cns;
			m_UDP.GetConnections(false, out cns);
			string[] nicks = new string[cns.Length];

			for(int i = 0; i < cns.Length; i++)
			{
				UserData ud = cns[i].UserObject as UserData;

				if(ud != null)
				{
					nicks[i] = ud.NickName;
				}
			}

			if(conn == null)
				m_UDP.SendUnreliableCommandToAll(BroadcastFilter.Clients | BroadcastFilter.AuthedOnly, 0, "23", nicks);
			else
				conn.SendUnreliableCommand(0, "23", nicks);
		}

		/// <summary>
		/// Server start button was clicked.
		/// </summary>
		private void btnStart_Click(object sender, System.EventArgs e)
		{
			m_UDP.StartListen(cmbIP.Text, Convert.ToInt32(txtPort.Text));
			spState.Text = "Starting server...";
		}

		/// <summary>
		/// Server stop button was clicked
		/// </summary>
		private void btnStop_Click(object sender, System.EventArgs e)
		{
			m_UDP.StopListen( );
			spState.Text = "Stopping server...";
		}

		/// <summary>
		/// Hide button was clicked
		/// </summary>
		private void btnHide_Click(object sender, System.EventArgs e)
		{
			this.Visible = false;
		}

		/// <summary>
		/// Tray icon was double clicked
		/// </summary>
		private void nIcon_DoubleClick(object sender, System.EventArgs e)
		{
			this.Visible = true;
		}
	}
}
