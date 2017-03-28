using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(SM_SpecialityType))]
#if Dev
    [RunLocal]
#endif

	public class SM_SpecialityType:ReadOnlyBase<SM_SpecialityType>
    {
        #region Business Methods

		
        public string SpecialityTypeCode
        {
            get ;
            set ;
        }

		
        public string SpecialityTypeName
        {
            get ;
            set ;
        }

		
        public string DegreeCode
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static SM_SpecialityType Create()
        {
            return EF.DataPortal.Create<SM_SpecialityType>();
        }

		public static SM_SpecialityType Fetch(System.Linq.Expressions.Expression<Func<SM_SpecialityType, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<SM_SpecialityType>(exp,values);
            return EF.DataPortal.Fetch<SM_SpecialityType>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(SM_SpecialityTypes))]
#if Dev
    [RunLocal]
#endif
	
	public class SM_SpecialityTypes:ReadOnlyListBase<SM_SpecialityTypes,SM_SpecialityType>
    {
        #region Factory Methods

        public static SM_SpecialityTypes Fetch()
        {
            return EF.DataPortal.Fetch<SM_SpecialityTypes>();
        }

		public static SM_SpecialityTypes Fetch(System.Linq.Expressions.Expression<Func<SM_SpecialityType, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<SM_SpecialityType>(exp,values);
            return EF.DataPortal.Fetch<SM_SpecialityTypes>(lambda);
		}

		public static SM_SpecialityTypes Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<SM_SpecialityTypes>(new Paging { Page=page,RowCount=rowCount});
        }

        public static SM_SpecialityTypes Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<SM_SpecialityType, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<SM_SpecialityTypes>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<SM_SpecialityType>(exp,values)});
        }

        #endregion

		[Serializable]
        public class Paging
        {
            public int Page { get; set; }
            public int RowCount { get; set; }
            public int StartIndex
            {
                get 
                {
                    if (Page >= 0 && RowCount > 0)
                    {
                        return Page * RowCount;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        [Serializable]
        public class PagigExpress
        {
            public int Page { get; set; }
            public int RowCount { get; set; }
            public int StartIndex
            {
                get
                {
                    if (Page >= 0 && RowCount > 0)
                    {
                        return Page * RowCount;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            public LambdaExpression Lambda { get; set; }
        }

    }
}
