using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataViewState
{
    public class Class1
    {
        public Class1()
        {
            using (DataViewStateEntities entities = new DataViewStateEntities())
            {
                System.Data.Objects.ObjectResult<GetElementValues_Result> r = entities.GetElementValues(Guid.Empty, "", "", "nvarchar(max)");

            }
        }
    }
}
