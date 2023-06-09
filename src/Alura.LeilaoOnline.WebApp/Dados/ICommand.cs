﻿using Alura.LeilaoOnline.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alura.LeilaoOnline.WebApp.Dados
{
    public interface ICommand<T>
    {
        void Incluir(T obj);
        void Alterar(T obj);
        void Excluir(T obj);
    }
}
