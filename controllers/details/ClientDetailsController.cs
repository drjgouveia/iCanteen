using iCantina.models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace iCantina.controllers
{
	public class ClientDetailsController : Controller
	{
		public ClientDetailsController() : base()
		{
			Console.WriteLine("Client Details controller initialized.");
		}

		public bool CreateStudent(string name, string nif, int number, float balance = 0)
		{
			try
			{
				if (context.Users.OfType<Professor>().FirstOrDefault(prof => prof.NIF == nif) != null)
				{
					return false;
				}
				Student student = new Student();
				student.Name = name;
				student.NIF = nif;
				student.StudentNumber = number;
				student.Balance = balance;
				Console.WriteLine("Creating student...");
				context.Users.Add(student);
				context.SaveChanges();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		public bool CreateProfessor(string name, string nif, string email, float balance = 0)
		{
			try
			{
				if (context.Users.OfType<Professor>().FirstOrDefault(prof => prof.NIF == nif) != null)
				{
					return false;
				}
				Professor professor = new Professor();
				professor.Name = name;
				professor.Email = email;
				professor.NIF = nif;
				professor.Balance = balance;
				Console.WriteLine("Creating professor...");
				context.Users.Add(professor);
				context.SaveChanges();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		public bool UpdateStudent(int id, string name, string nif, int number, float balance = 0)
		{
			try
			{
				Student student = context.Users.OfType<Student>().FirstOrDefault(s => s.Id == id);
				student.Name = name;
				student.NIF = nif;
				student.StudentNumber = number;
				student.Balance = balance;
				Console.WriteLine("Updating student...");
				context.SaveChanges();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		public bool UpdateProfessor(int id, string name, string nif, string email, float balance = 0)
		{
			try
			{
				Professor professor = context.Users.OfType<Professor>().FirstOrDefault(p => p.Id == id);
				professor.Name = name;
				professor.Email = email;
				professor.NIF = nif;
				professor.Balance = balance;
				Console.WriteLine("Updating professor...");
				context.SaveChanges();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		public bool DeleteStudent(int id)
		{
			try
			{
				Student student = context.Users.OfType<Student>().FirstOrDefault(s => s.Id == id);
				Console.WriteLine("Deleting student...");
				context.Users.Remove(student);
				context.SaveChanges();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		public bool DeleteProfessor(int id)
		{
			try
			{
				Professor professor = context.Users.OfType<Professor>().FirstOrDefault(p => p.Id == id);
				Console.WriteLine("Deleting professor...");
				context.Users.Remove(professor);
				context.SaveChanges();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		public List<Student> GetStudents()
		{
			return context.Users.OfType<Student>().ToList();
		}

		public List<Professor> GetProfessors()
		{
			return context.Users.OfType<Professor>().ToList();
		}

		internal object GetInvoicesOfClient(Client client)
		{
			return context.Invoices.Where(i => i.Client.Id == client.Id).ToList();
		}

		public bool OpenInvoice()
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Filter = "PDF files (*.pdf)|*.pdf", 
                    Title = "Abrir fatura"
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        ProcessStartInfo processStartInfo = new ProcessStartInfo
                        {
                            FileName = openFileDialog.FileName,
                            UseShellExecute = true 
                        };
                        Process.Start(processStartInfo);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Não foi possível abrir o arquivo PDF: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
	}
}
