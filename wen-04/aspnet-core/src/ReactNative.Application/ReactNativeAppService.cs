using System;
using System.Collections.Generic;
using System.Text;
using ReactNative.Localization;
using Volo.Abp.Application.Services;

namespace ReactNative;

/* Inherit your application services from this class.
 */
public abstract class ReactNativeAppService : ApplicationService
{
    protected ReactNativeAppService()
    {
        LocalizationResource = typeof(ReactNativeResource);
    }
}
