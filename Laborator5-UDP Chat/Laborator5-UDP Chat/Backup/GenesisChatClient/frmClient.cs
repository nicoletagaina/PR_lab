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
using System.Runtime.InteropServices;
using GenesisCore;

namespace GenesisChatClient
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class frmClient : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TabControl tcMain;
		private System.Windows.Forms.TabPage tpSettings;
		private System.Windows.Forms.TabPage tpChat;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmbIPAddress;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtPort;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Button btnStop;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtServerIP;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnConnect;
		private System.Windows.Forms.TextBox txtServerPort;
		private System.Windows.Forms.TextBox txtSend;
		private System.Windows.Forms.Button btnSend;
		private GenesisChatClient.ExRichTextBox txtReceived;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.StatusBar sbStatus;
		private System.Windows.Forms.StatusBarPanel spState;
		private System.Windows.Forms.TextBox txtServerPW;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtNickName;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ListBox lstUsers;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ContextMenu cmReceivedMenu;
		private System.Windows.Forms.MenuItem miClear;
		private System.Windows.Forms.CheckBox chkFlashing;

		private GenesisCore.IGenesisUDP m_UDP;
		private GenesisCore.IConnection m_ServerConn;
		private string server_ip;
		private string server_req_id;

		public frmClient()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			m_UDP = GenesisCore.InterfaceFactory.CreateGenesisUDP("ChatClient");
			spState.Text = "Genesis Core initialised.";
			server_ip = "";
			server_req_id = "";
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClient));
            this.tcMain = new System.Windows.Forms.TabControl( );
            this.tpSettings = new System.Windows.Forms.TabPage( );
            this.groupBox2 = new System.Windows.Forms.GroupBox( );
            this.txtServerPW = new System.Windows.Forms.TextBox( );
            this.label5 = new System.Windows.Forms.Label( );
            this.btnConnect = new System.Windows.Forms.Button( );
            this.txtServerPort = new System.Windows.Forms.TextBox( );
            this.label4 = new System.Windows.Forms.Label( );
            this.txtServerIP = new System.Windows.Forms.TextBox( );
            this.label3 = new System.Windows.Forms.Label( );
            this.groupBox1 = new System.Windows.Forms.GroupBox( );
            this.chkFlashing = new System.Windows.Forms.CheckBox( );
            this.txtNickName = new System.Windows.Forms.TextBox( );
            this.label6 = new System.Windows.Forms.Label( );
            this.btnStop = new System.Windows.Forms.Button( );
            this.btnStart = new System.Windows.Forms.Button( );
            this.txtPort = new System.Windows.Forms.TextBox( );
            this.label2 = new System.Windows.Forms.Label( );
            this.cmbIPAddress = new System.Windows.Forms.ComboBox( );
            this.label1 = new System.Windows.Forms.Label( );
            this.tpChat = new System.Windows.Forms.TabPage( );
            this.label7 = new System.Windows.Forms.Label( );
            this.lstUsers = new System.Windows.Forms.ListBox( );
            this.txtReceived = new GenesisChatClient.ExRichTextBox( );
            this.cmReceivedMenu = new System.Windows.Forms.ContextMenu( );
            this.miClear = new System.Windows.Forms.MenuItem( );
            this.btnSend = new System.Windows.Forms.Button( );
            this.txtSend = new System.Windows.Forms.TextBox( );
            this.sbStatus = new System.Windows.Forms.StatusBar( );
            this.spState = new System.Windows.Forms.StatusBarPanel( );
            this.tcMain.SuspendLayout( );
            this.tpSettings.SuspendLayout( );
            this.groupBox2.SuspendLayout( );
            this.groupBox1.SuspendLayout( );
            this.tpChat.SuspendLayout( );
            ((System.ComponentModel.ISupportInitialize)(this.spState)).BeginInit( );
            this.SuspendLayout( );
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpSettings);
            this.tcMain.Controls.Add(this.tpChat);
            this.tcMain.ItemSize = new System.Drawing.Size(150, 18);
            this.tcMain.Location = new System.Drawing.Point(8, 8);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(576, 312);
            this.tcMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcMain.TabIndex = 0;
            // 
            // tpSettings
            // 
            this.tpSettings.Controls.Add(this.groupBox2);
            this.tpSettings.Controls.Add(this.groupBox1);
            this.tpSettings.Location = new System.Drawing.Point(4, 22);
            this.tpSettings.Name = "tpSettings";
            this.tpSettings.Size = new System.Drawing.Size(568, 286);
            this.tpSettings.TabIndex = 0;
            this.tpSettings.Text = "Settings";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtServerPW);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnConnect);
            this.groupBox2.Controls.Add(this.txtServerPort);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtServerIP);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(72, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(416, 120);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Server Settings";
            // 
            // txtServerPW
            // 
            this.txtServerPW.Location = new System.Drawing.Point(8, 88);
            this.txtServerPW.Name = "txtServerPW";
            this.txtServerPW.PasswordChar = '*';
            this.txtServerPW.Size = new System.Drawing.Size(136, 21);
            this.txtServerPW.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(8, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Server Password";
            // 
            // btnConnect
            // 
            this.btnConnect.Enabled = false;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnConnect.Location = new System.Drawing.Point(272, 32);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(136, 24);
            this.btnConnect.TabIndex = 7;
            this.btnConnect.Text = "Connect to Server";
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtServerPort
            // 
            this.txtServerPort.Location = new System.Drawing.Point(160, 38);
            this.txtServerPort.Name = "txtServerPort";
            this.txtServerPort.Size = new System.Drawing.Size(72, 21);
            this.txtServerPort.TabIndex = 6;
            this.txtServerPort.Text = "27000";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(160, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Server Port";
            // 
            // txtServerIP
            // 
            this.txtServerIP.Location = new System.Drawing.Point(8, 40);
            this.txtServerIP.Name = "txtServerIP";
            this.txtServerIP.Size = new System.Drawing.Size(136, 21);
            this.txtServerIP.TabIndex = 4;
            this.txtServerIP.Text = "10.0.0.12";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(8, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Server IP Address";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkFlashing);
            this.groupBox1.Controls.Add(this.txtNickName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnStop);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Controls.Add(this.txtPort);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbIPAddress);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(72, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 120);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "My Settings";
            // 
            // chkFlashing
            // 
            this.chkFlashing.Checked = true;
            this.chkFlashing.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFlashing.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkFlashing.Location = new System.Drawing.Point(272, 80);
            this.chkFlashing.Name = "chkFlashing";
            this.chkFlashing.Size = new System.Drawing.Size(112, 16);
            this.chkFlashing.TabIndex = 8;
            this.chkFlashing.Text = "Enable flashing";
            // 
            // txtNickName
            // 
            this.txtNickName.Location = new System.Drawing.Point(8, 88);
            this.txtNickName.Name = "txtNickName";
            this.txtNickName.Size = new System.Drawing.Size(136, 21);
            this.txtNickName.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(8, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "NickName";
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnStop.Location = new System.Drawing.Point(272, 48);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(136, 24);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "Stop Client";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnStart.Location = new System.Drawing.Point(272, 16);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(136, 24);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start Client";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(160, 40);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(72, 21);
            this.txtPort.TabIndex = 3;
            this.txtPort.Text = "27001";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(160, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port";
            // 
            // cmbIPAddress
            // 
            this.cmbIPAddress.Location = new System.Drawing.Point(8, 40);
            this.cmbIPAddress.Name = "cmbIPAddress";
            this.cmbIPAddress.Size = new System.Drawing.Size(136, 21);
            this.cmbIPAddress.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP Address";
            // 
            // tpChat
            // 
            this.tpChat.Controls.Add(this.label7);
            this.tpChat.Controls.Add(this.lstUsers);
            this.tpChat.Controls.Add(this.txtReceived);
            this.tpChat.Controls.Add(this.btnSend);
            this.tpChat.Controls.Add(this.txtSend);
            this.tpChat.Location = new System.Drawing.Point(4, 22);
            this.tpChat.Name = "tpChat";
            this.tpChat.Size = new System.Drawing.Size(568, 286);
            this.tpChat.TabIndex = 1;
            this.tpChat.Text = "Chat";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(432, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Connected Users";
            // 
            // lstUsers
            // 
            this.lstUsers.Location = new System.Drawing.Point(432, 24);
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.Size = new System.Drawing.Size(128, 251);
            this.lstUsers.TabIndex = 3;
            // 
            // txtReceived
            // 
            this.txtReceived.ContextMenu = this.cmReceivedMenu;
            this.txtReceived.HideSelection = false;
            this.txtReceived.HiglightColor = GenesisChatClient.RtfColor.White;
            this.txtReceived.Location = new System.Drawing.Point(8, 8);
            this.txtReceived.Name = "txtReceived";
            this.txtReceived.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.txtReceived.Size = new System.Drawing.Size(416, 224);
            this.txtReceived.TabIndex = 2;
            this.txtReceived.Text = "";
            this.txtReceived.TextColor = GenesisChatClient.RtfColor.Black;
            // 
            // cmReceivedMenu
            // 
            this.cmReceivedMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.miClear});
            // 
            // miClear
            // 
            this.miClear.Index = 0;
            this.miClear.Text = "&Clear";
            this.miClear.Click += new System.EventHandler(this.miClear_Click);
            // 
            // btnSend
            // 
            this.btnSend.Enabled = false;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSend.Location = new System.Drawing.Point(360, 240);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(64, 40);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtSend
            // 
            this.txtSend.AcceptsReturn = true;
            this.txtSend.Location = new System.Drawing.Point(8, 240);
            this.txtSend.MaxLength = 200;
            this.txtSend.Multiline = true;
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(344, 40);
            this.txtSend.TabIndex = 0;
            this.txtSend.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSend_KeyDown);
            // 
            // sbStatus
            // 
            this.sbStatus.Location = new System.Drawing.Point(0, 327);
            this.sbStatus.Name = "sbStatus";
            this.sbStatus.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.spState});
            this.sbStatus.ShowPanels = true;
            this.sbStatus.Size = new System.Drawing.Size(594, 24);
            this.sbStatus.SizingGrip = false;
            this.sbStatus.TabIndex = 1;
            // 
            // spState
            // 
            this.spState.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
            this.spState.Name = "spState";
            this.spState.Text = "Application loaded.";
            this.spState.Width = 594;
            // 
            // frmClient
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
            this.ClientSize = new System.Drawing.Size(594, 351);
            this.Controls.Add(this.sbStatus);
            this.Controls.Add(this.tcMain);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmClient";
            this.Text = "Genesis Client";
            this.Closed += new System.EventHandler(this.frmClient_Closed);
            this.Load += new System.EventHandler(this.frmClient_Load);
            this.tcMain.ResumeLayout(false);
            this.tpSettings.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout( );
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout( );
            this.tpChat.ResumeLayout(false);
            this.tpChat.PerformLayout( );
            ((System.ComponentModel.ISupportInitialize)(this.spState)).EndInit( );
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
			Application.Run(new frmClient());
		}

		private void frmClient_Load(object sender, System.EventArgs e)
		{
			string[] addresses = m_UDP.GetLocalAddresses( );
			cmbIPAddress.Items.Clear( );
			if(addresses.Length > 0)
			{
				for(int i = 0; i < addresses.Length; i++)
					cmbIPAddress.Items.Add(addresses[i]);

				cmbIPAddress.Text = (string)cmbIPAddress.Items[0];
			}

			m_UDP.OnListenStateChanged += new ListenHandler(m_UDP_OnListenStateChanged);
			m_UDP.OnLoginRequested += new SendLoginHandler(m_UDP_OnLoginRequested);
			m_UDP.OnAuthFeedback += new AuthenticatedHandler(m_UDP_OnAuthFeedback);
			m_UDP.OnConnectionStateChanged += new ConnectionStateChangeHandler(m_UDP_OnConnectionStateChanged);
			m_UDP.OnCommandReceived += new IncomingCommandHandler(m_UDP_OnCommandReceived);
			m_UDP.OnConnectionAuth += new ConnectionAuthHandler(m_UDP_OnConnectionAuth);
			m_UDP.OnSocketError += new SocketErrorHandler(m_UDP_OnSocketError);
			m_UDP.OnConnectionRequestTimedOut += new RequestTimedOutHandler(m_UDP_OnConnectionRequestTimedOut);
		}

		/// <summary>
		/// Chat client window was closed.
		/// </summary>
		private void frmClient_Closed(object sender, System.EventArgs e)
		{
			m_UDP.StopListen( );

			m_UDP.OnListenStateChanged -= new ListenHandler(m_UDP_OnListenStateChanged);
			m_UDP.OnLoginRequested -= new SendLoginHandler(m_UDP_OnLoginRequested);
			m_UDP.OnAuthFeedback -= new AuthenticatedHandler(m_UDP_OnAuthFeedback);
			m_UDP.OnConnectionStateChanged -= new ConnectionStateChangeHandler(m_UDP_OnConnectionStateChanged);
			m_UDP.OnCommandReceived -= new IncomingCommandHandler(m_UDP_OnCommandReceived);
			m_UDP.OnConnectionAuth -= new ConnectionAuthHandler(m_UDP_OnConnectionAuth);
			m_UDP.OnSocketError -= new SocketErrorHandler(m_UDP_OnSocketError);
		}

		#region Event handling
		/// <summary>
		/// UDP engine has started or stopped listening.
		/// </summary>
		private void m_UDP_OnListenStateChanged(object o, ListenEventArgs e) { this.Invoke(new GenesisCore.ListenHandler(OnListenStateChanged), new object[] {o, e}); }
		private void OnListenStateChanged(object o, ListenEventArgs e)
		{
			if(e.Listening)
				spState.Text = "Client started.";
			else
				spState.Text = "Client stopped.";

			btnStart.Enabled = (!e.Listening);
			btnStop.Enabled = e.Listening;
			btnConnect.Enabled = e.Listening;
		}

		/// <summary>
		/// Server has asked for our login details.
		/// </summary>
		private void m_UDP_OnLoginRequested(object o, LoginSendEventArgs e)	{ this.Invoke(new GenesisCore.SendLoginHandler(OnLoginRequested), new object[] {o, e}); }
		private void OnLoginRequested(object o, LoginSendEventArgs e)
		{
			if(e.Connected)
			{
                //Send a command containing the login information (Field 0 = Server PW, Field 1 = User nickname).
				e.ServerConnection.SendUnreliableCommand(0, GenesisConsts.OPCODE_LOGINDETAILS, new string[] {txtServerPW.Text, txtNickName.Text} );
				spState.Text = "Sending login details...";
			}
			else
			{
                //Server could not process our connection at this time (possibly full?)
				spState.Text = "Connection rejected - " + e.Reason;
			}
		}

		/// <summary>
		/// Server has accepted or rejected our login details.
		/// </summary>
		private void m_UDP_OnAuthFeedback(object o, AuthenticatedEventArgs e) {	this.Invoke(new GenesisCore.AuthenticatedHandler(OnAuthFeedback), new object[] {o, e});	}
		private void OnAuthFeedback(object o, AuthenticatedEventArgs e)
		{
			if(e.Accepted)
			{
                //We have been authenticated with the server.
				spState.Text = "Authenticated with server.";

                //Send a command to ask for a user list (opcode = "23", no fields).
				e.ServerConnection.SendUnreliableCommand(0, "23", new string[0]);
				
				//Select the chat page
				tcMain.SelectedIndex = 1;
				txtSend.Focus( );
			}
			else
			{
                //The server didn't like our login details for some reason.
				spState.Text = "Authentication failed - " + e.Reason;
			}
		}

		/// <summary>
		/// Fired when a connection has been established or lost
		/// </summary>
		private void m_UDP_OnConnectionStateChanged(object o, ConnectionStateChangeEventArgs e)	{ this.Invoke(new GenesisCore.ConnectionStateChangeHandler(OnConnectionStateChanged), new object[] {o, e}); }
		private void OnConnectionStateChanged(object o, ConnectionStateChangeEventArgs e)
		{
			if(e.Connected)
			{
                /* The connection attempt has succeeded?
                  (Compare the connection request ID to the one we stored when we called RequestConnect( )*/
				if(e.Connection.RequestID == server_req_id)
				{
					m_ServerConn = e.Connection;
					btnConnect.Enabled = false;
					txtServerIP.Enabled = false;
					txtServerPort.Enabled = false;
					txtServerPW.Enabled = false;
					txtNickName.Enabled = false;
					btnSend.Enabled = true;
					txtSend.Enabled = true;
				}
			}
			else
			{
                //Connection to the server has been lost.
				if(e.Connection == m_ServerConn)
				{
					btnConnect.Enabled = true;
					txtServerIP.Enabled = true;
					txtServerPort.Enabled = true;
					txtServerPW.Enabled = true;
					txtNickName.Enabled = true;
					btnSend.Enabled = false;
					txtSend.Enabled = false;
					txtReceived.Text = "";
					lstUsers.Items.Clear( );

					m_ServerConn = null;
					spState.Text = "Disconnected from server - (" + e.Disconnect_Reason + ").";
				}
			}
		}

		/// <summary>
		/// Remote host tried to connect directly to us
		/// </summary>
		private void m_UDP_OnConnectionAuth(object o, ConnectionAuthEventArgs e)
		{
            //Clients don't accept connections.
			e.AllowConnection = false;
			e.DisallowReason = "Can't connect directly to a chat client";
		}

		/// <summary>
		/// Command has been received.
		/// </summary>
		private void m_UDP_OnCommandReceived(object o, CommandEventArgs e) { this.Invoke(new GenesisCore.IncomingCommandHandler(OnCommandReceived), new object[] {o, e}); }
		private void OnCommandReceived(object o, CommandEventArgs e)
		{
			//Incoming chat message (these opcodes are simply defined by the chat application).
			if(e.SentCommand.OPCode == "21")
			{
				//Client said nothing?
				if(e.SentCommand.Fields[1] == "")
					return;

				//Field 0 is the senders nickname
				//Field 1 is what the sender said.

				//Stop the textbox redrawing
				txtReceived.SuspendLayout( );

				//Set the fonts
				System.Drawing.Font nickfn = new Font("Arial", 8, FontStyle.Bold);
				System.Drawing.Font chatfn = new Font("Arial", 8, FontStyle.Regular);

				if(e.SentCommand.Fields[0] != txtNickName.Text)
					txtReceived.AppendTextAsRtf(e.SentCommand.Fields[0] + "> ", nickfn, RtfColor.Blue);
				else
					txtReceived.AppendTextAsRtf(e.SentCommand.Fields[0] + "> ", nickfn, RtfColor.Red);

				txtReceived.AppendTextAsRtf(e.SentCommand.Fields[1] + "\r\n", chatfn, RtfColor.Black);

				//Make sure the recieved textbox doesnt get too big
				if(txtReceived.Text.Length > 2000)
				{
					txtReceived.Select(0, 500);
					txtReceived.SelectedText = ".";
				}

				//Application.DoEvents( );
				txtReceived.Select(txtReceived.Text.Length, 0);
				txtReceived.ScrollToCaret( );

				//Resume redraw
				txtReceived.ResumeLayout(true);

				//Flash window
				if(chkFlashing.Checked)
				{
					FLASHWINFO finfo = new FLASHWINFO();
					finfo.cbSize = (uint) System.Runtime.InteropServices.Marshal.SizeOf(finfo);
					finfo.hwnd = this.Handle;
					finfo.uCount = 600;
					finfo.dwTimeout = 400;
					finfo.dwFlags = PInvoke.FLASHW_TRAY | PInvoke.FLASHW_TIMER | PInvoke.FLASHW_TIMERNOFG;

					if(this.WindowState == FormWindowState.Minimized)
						PInvoke.FlashWindowEx(ref finfo);
				}
			}

			//Connection or disconnection of a user
			if(e.SentCommand.OPCode == "22")
			{
				//Field 0 is the users name
				//Field 1 is 0 for disconnected, or 1 for connected

				//Stop the textbox redrawing
				txtReceived.SuspendLayout( );

				System.Drawing.Font chatfn = new Font("Arial", 8, FontStyle.Regular);
				if(e.SentCommand.Fields[1] == "0")
					txtReceived.AppendTextAsRtf("*** " + e.SentCommand.Fields[0] + " disconnected.\r\n", chatfn, RtfColor.Green);
				else
					txtReceived.AppendTextAsRtf("*** " + e.SentCommand.Fields[0] + " connected.\r\n", chatfn, RtfColor.Green);

				//Make sure the recieved textbox doesnt get too big
				if(txtReceived.Text.Length > 2000)
				{
					txtReceived.Select(0, 500);
					txtReceived.SelectedText = ".";
				}

				//Application.DoEvents( );
				txtReceived.Select(txtReceived.Text.Length, 0);
				txtReceived.ScrollToCaret( );

				//Resume redraw
				txtReceived.ResumeLayout(true);
			}

			//User list
			if(e.SentCommand.OPCode == "23")
			{
				lstUsers.Items.Clear( );
				for(int i = 0; i < e.SentCommand.Fields.Length; i++)
					lstUsers.Items.Add(e.SentCommand.Fields[i]);
			}
		}

		/// <summary>
		/// Socket error has occured! Tell the user.
		/// </summary>
		private void m_UDP_OnSocketError(object o, SocketEventArgs e) { this.Invoke(new GenesisCore.SocketErrorHandler(OnSocketError), new object[] {o, e}); }
		private void OnSocketError(object o, SocketEventArgs e)
		{
			MessageBox.Show("Socket error - " + e.Message + " (" + e.ErrorCode.ToString() + ").", "Socket error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		/// <summary>
		/// Connection request timed out.
		/// </summary>
		private void m_UDP_OnConnectionRequestTimedOut(object o, RequestTimedOutEventArgs e) { this.Invoke(new GenesisCore.RequestTimedOutHandler(OnConnectionRequestTimedOut), new object [] {o, e}); }
		private void OnConnectionRequestTimedOut(object o, RequestTimedOutEventArgs e)
		{
			spState.Text = "Connection request to " + e.ServerIP + ":" + e.ServerPort.ToString() + " timed out.";
			btnConnect.Enabled = true;
		}
		#endregion

		/// <summary>
		/// Client start button was clicked
		/// </summary>
		private void btnStart_Click(object sender, System.EventArgs e)
		{
			m_UDP.StartListen(cmbIPAddress.Text, Convert.ToInt32(txtPort.Text));
			spState.Text = "Starting client...";
		}

		/// <summary>
		/// Client stop button was clicked
		/// </summary>
		private void btnStop_Click(object sender, System.EventArgs e)
		{
			m_UDP.StopListen( );
			spState.Text = "Stopping client...";
		}

		/// <summary>
		/// Connect to server button was clicked
		/// </summary>
		private void btnConnect_Click(object sender, System.EventArgs e)
		{
			server_ip = txtServerIP.Text;
			m_UDP.RequestConnect(ref server_ip, Convert.ToInt32(txtServerPort.Text), out server_req_id);
			spState.Text = "Connecting...";
			btnConnect.Enabled = true;
		}

		/// <summary>
		/// Send button was clicked, send the chat packet and clear the send text.
		/// </summary>
		private void btnSend_Click(object sender, System.EventArgs e)
		{
			if(btnSend.Enabled)
			{
				m_ServerConn.SendUnreliableCommand(0, "20", new string[] {txtSend.Text});
				txtSend.Text = "";
			}
		}

		/// <summary>
		/// Hook keys pressed in the send text box, used for catching the Ctrl-enter
		/// send shortcut
		/// </summary>
		private void txtSend_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.Control)
				if(e.KeyCode == Keys.Enter)
				{
					btnSend_Click(this, new EventArgs( ));
					e.Handled = true;

					Application.DoEvents( );
					txtSend.Text = "";
				}
		}

		/// <summary>
		/// Clear menu item was clicked.
		/// </summary>
		private void miClear_Click(object sender, System.EventArgs e)
		{
			System.Drawing.Font chatfn = new Font("Arial", 8, FontStyle.Regular);

			txtReceived.ResetText( );

			txtReceived.AppendTextAsRtf("*** Chat window cleared.\r\n", chatfn, RtfColor.Silver);
		}
	}
}
