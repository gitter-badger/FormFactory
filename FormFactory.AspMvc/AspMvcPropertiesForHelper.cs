using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web.Mvc;
using FormFactory.AspMvc;
using FormFactory.AspMvc.ModelBinders;
using FormFactory.AspMvc.Wrappers;

namespace FormFactory
{
    public static class AspMvcPropertiesForHelper
    {

        public static IEnumerable<PropertyVm> PropertiesFor<T>(this System.Web.Mvc.HtmlHelper helper, T model)
        {
            return helper.PropertiesFor(model, typeof(T));
        }

        public static IEnumerable<PropertyVm> PropertiesFor(this System.Web.Mvc.HtmlHelper helper, object model, Type fallbackModelType)
        {
            return VmHelper.PropertiesFor(new Encoder(), model, fallbackModelType);
        }
        public static PropertyVm PropertyVm(this HtmlHelper html, Type type, string name, object value)
        {
            return new PropertyVm( type, name ){ Value = value};
        }
         
    }
}