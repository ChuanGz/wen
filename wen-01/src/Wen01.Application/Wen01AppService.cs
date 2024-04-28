using System;
using System.Collections.Generic;
using System.Text;
using Wen01.Localization;
using Volo.Abp.Application.Services;

namespace Wen01;

/* Inherit your application services from this class.
 */
public abstract class Wen01AppService : ApplicationService
{
    protected Wen01AppService()
    {
        LocalizationResource = typeof(Wen01Resource);
    }
}
