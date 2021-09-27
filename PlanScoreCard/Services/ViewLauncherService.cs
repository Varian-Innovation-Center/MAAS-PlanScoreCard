﻿using Autofac;
using PlanScoreCard.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanScoreCard.Services
{
    public class ViewLauncherService
    {
        private readonly IComponentContext Context;

        /// <summary>
        /// Constructor that takes a component context through dependency injection
        /// </summary>
        /// <param name="componentContext"></param>
        public ViewLauncherService(IComponentContext componentContext)
        {
            Context = componentContext;
        }

        /// <summary>
        /// Generate a home view
        /// </summary>
        /// <returns></returns>
        public EditScoreCardView GetEditScoreCardView()
        {
            return GetView<EditScoreCardView>();
        }


        /// <summary>
        /// Generate a home view
        /// </summary>
        /// <returns></returns>
        public EditScoreCardView GetEditMetricView_DoseAtVolume()
        {
            return GetView<EditScoreCardView>();
        }

        /// <summary>
        /// Generate a generic view
        /// </summary>
        /// <returns></returns>
        public T GetView<T>()
        {
            return Context.Resolve<T>();
        }

        /// <summary>
        /// Generate a view specified by the passed in type
        /// </summary>
        /// <returns></returns>
        public object GetView(Type type)
        {
            return Context.Resolve(type);
        }
    }
}
