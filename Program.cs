﻿using FitManager.Core.Interfaces;
using FitManager.Core.Services;
using FitManager.Data.Repositories;
using FitManager.Presentation.Menus;

IAlunoRepository repoAluno = new AlunoRepository();
IAlunoService alunoService = new AlunoService(repoAluno);
var menuAluno = new MenuAluno(alunoService);

var menuPrincipal = new MenuPrincipal(menuAluno);
menuPrincipal.Exibir();
