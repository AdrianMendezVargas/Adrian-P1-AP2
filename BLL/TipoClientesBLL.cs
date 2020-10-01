using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Adrian_P1_AP2.DAL;
using Adrian_P1_AP2.Models;
using Microsoft.EntityFrameworkCore;

namespace Adrian_P1_AP2.BLL
{
    public class TipoClientesBLL
    {

        public async static Task<bool> Guardar(TipoCliente tipoCliente)
        {
            if (!await Existe(tipoCliente.TipoClienteId))
                return await Insertar(tipoCliente);
            else
                return await Modificar(tipoCliente);
        }

        private async static Task<bool> Insertar(TipoCliente tipoCliente)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.TipoClientes.Add(tipoCliente);
                paso = await contexto.SaveChangesAsync() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                await contexto.DisposeAsync();
            }

            return paso;
        }

        public async static Task<bool> Modificar(TipoCliente tipoCliente)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(tipoCliente).State = EntityState.Modified;

                paso = await contexto.SaveChangesAsync() > 0;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                await contexto.DisposeAsync();
            }
            return paso;
        }

        public async static Task<bool> Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                var tipoCliente = contexto.TipoClientes.Find(id);

                if (tipoCliente != null)
                {
                    contexto.TipoClientes.Remove(tipoCliente);
                    paso = await contexto.SaveChangesAsync() > 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                await contexto.DisposeAsync();
            }

            return paso;
        }

        public async static Task<TipoCliente> Buscar(int id)
        {
            Contexto contexto = new Contexto();
            TipoCliente tipoCliente;

            try
            {
                tipoCliente = await contexto.TipoClientes
                    .Where(e => e.TipoClienteId == id)
                    .FirstOrDefaultAsync();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                await contexto.DisposeAsync();
            }

            return tipoCliente;
        }


        public async static Task<bool> Existe(int id)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;

            try
            {
                encontrado = await contexto.TipoClientes.AnyAsync(e => e.TipoClienteId == id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                await contexto.DisposeAsync();
            }

            return encontrado;
        }

        public async static Task<List<TipoCliente>> GetTipoClientes()
        {
            Contexto contexto = new Contexto();

            List<TipoCliente> tipoClientes = new List<TipoCliente>();
            await Task.Delay(01); //Para dar tiempo a renderizar el mensaje de carga

            try
            {
                tipoClientes = await contexto.TipoClientes.ToListAsync();

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                await contexto.DisposeAsync();
            }

            return tipoClientes;

        }
        
    }
}