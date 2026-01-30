
using System;
using System.IO;
using System.Net;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
using System.DirectoryServices.Protocols;
using System.Drawing.Text;

namespace OpenGate.UC.LDAP
{
    public partial class GestionLDAP : UserControl
    {
        public GestionLDAP()
        {
            InitializeComponent();

            // État initial : tout désactivé
            SetControlsEnabled(stateLDAP.Checked);
            SetBindControlsEnabled(stateCredentials.Checked);

            // Ajouter l’événement
            stateLDAP.CheckedChanged += (sender, e) =>
            {
                SetControlsEnabled(stateLDAP.Checked);
            };

            stateCredentials.CheckedChanged += (sender, e) =>
            {
                SetBindControlsEnabled(stateCredentials.Checked);
            };
        }

        // Modèle de configuration
        private class LdapConfig
        {
            public required string Server { get; set; }
            public int Port { get; set; }
            public string? BindDn { get; set; }
            public required string BaseDn { get; set; }
            public string? Password { get; set; }
            public string? UserFilter { get; set; }
        }

        // Lecture UI
        private LdapConfig ReadForm()
        {
            return new LdapConfig
            {
                Server = txtServer.Text.Trim(),
                Port = int.Parse(txtPort.Text),
                BindDn = txtDN.Text.Trim(),
                Password = txtMDP.Text,
                UserFilter = txtUserFilter.Text.Trim(),
                BaseDn = txtBaseDN.Text.Trim()
            };
        }

        private void SetControlsEnabled(bool enabled)
        {
            // Groupe Connexion LDAP
            txtServer.Enabled = enabled;
            txtPort.Enabled = enabled;
            txtBaseDN.Enabled = enabled;

            // Groupe Bind
            stateCredentials.Enabled = enabled;

            // Groupe Option
            txtUserFilter.Enabled = enabled;

            // Boutons
            btnTest.Enabled = enabled;
            btnSave.Enabled = enabled;
        }

        private void SetBindControlsEnabled(bool enabled)
        {
            txtDN.Enabled = enabled;
            txtMDP.Enabled = enabled;
        }

        // Test connexion LDAP
        private void TestLdap(LdapConfig config)
        {
            var identifier = new LdapDirectoryIdentifier(
                config.Server,
                config.Port
            );

            LdapConnection connection;

            if (!string.IsNullOrWhiteSpace(config.BindDn) && !string.IsNullOrWhiteSpace(config.Password))
            {
                // Utilisation des credentials si fournis
                var credential = new NetworkCredential(config.BindDn, config.Password);
                connection = new LdapConnection(identifier, credential);
            }
            else
            {
                // Connexion anonyme si BindDn et Password vides
                connection = new LdapConnection(identifier);
            }

            connection.Bind();
            if (!string.IsNullOrWhiteSpace(config.BaseDn))
            {
                var request = new SearchRequest(
                    config.BaseDn,
                    "(objectClass=*)",   // simple filtre pour vérifier l'existence
                    SearchScope.Base,
                    null
                );

                var response = (SearchResponse)connection.SendRequest(request);
                // exception si Base DN invalide
            }
        }

        // Bouton TEST
        private void btnTest_Click(object sender, EventArgs e)
        {
            try
            {
                var config = ReadForm();
                TestLdap(config);

                MessageBox.Show(
                    "Connexion LDAP OK ✅",
                    "LDAP",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Connexion LDAP échouée ❌\n" + ex.Message,
                    "LDAP",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // Bouton SAVE
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var config = ReadForm();

                var json = JsonSerializer.Serialize(
                    config,
                    new JsonSerializerOptions { WriteIndented = true }
                );

                File.WriteAllText("ldap-config.json", json);

                MessageBox.Show(
                    "Configuration LDAP enregistrée 💾",
                    "LDAP",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erreur sauvegarde ❌\n" + ex.Message,
                    "LDAP",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
