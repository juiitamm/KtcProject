using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KtcProject1.Binders
{
    public class ListModelBinder<T> : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            var form = controllerContext.HttpContext.Request.Form;
            List<T> results = new List<T>();
            var PropInfo = typeof(T).GetProperties();

            foreach (string s in form.AllKeys)
            {
                //Initialize a new object:
                T o = Activator.CreateInstance<T>();
                foreach (var item in PropInfo)
                {
                    //Only interested in Name-property in Player's case:
                    if(s.Contains(item.Name))
                        //Apply the value from the form to the correct property:
                        o.GetType().GetProperty(item.Name).SetValue(o, form[s], null);
                }
                results.Add(o);
            }
            return results;
        }
    }
}