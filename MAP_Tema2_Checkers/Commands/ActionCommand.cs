﻿using System;
using System.Windows.Input;

namespace MAP_Tema2_Checkers.Commands
{
    class ActionCommand : ICommand
    {
        private readonly Action commandTask;
        private readonly Func<bool> canExecuteTask;

        public ActionCommand(Action workToDo, Func<bool> canExecute)
        {
            commandTask = workToDo;
            canExecuteTask = canExecute;
        }

        public ActionCommand(Action workToDo)
            : this(workToDo, DefaultCanExecute)
        {
            commandTask = workToDo;
        }

        private static bool DefaultCanExecute()
        {
            return true;
        }

        public bool CanExecute(object parameter)
        {
            return canExecuteTask != null && canExecuteTask();
        }

        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }

            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }

        public void Execute(object parameter)
        {
            commandTask();
        }
    }
}
