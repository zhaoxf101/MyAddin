using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(TM_SpecialityType))]
#if Dev
    [RunLocal]
#endif

	public class TM_SpecialityType:ReadOnlyBase<TM_SpecialityType>
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

		public static TM_SpecialityType Create()
        {
            return EF.DataPortal.Create<TM_SpecialityType>();
        }

		public static TM_SpecialityType Fetch(System.Linq.Expressions.Expression<Func<TM_SpecialityType, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<TM_SpecialityType>(exp,values);
            return EF.DataPortal.Fetch<TM_SpecialityType>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(TM_SpecialityTypes))]
#if Dev
    [RunLocal]
#endif
	
	public class TM_SpecialityTypes:ReadOnlyListBase<TM_SpecialityTypes,TM_SpecialityType>
    {
        #region Factory Methods

        public static TM_SpecialityTypes Fetch()
        {
            return EF.DataPortal.Fetch<TM_SpecialityTypes>();
        }

		public static TM_SpecialityTypes Fetch(System.Linq.Expressions.Expression<Func<TM_SpecialityType, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<TM_SpecialityType>(exp,values);
            return EF.DataPortal.Fetch<TM_SpecialityTypes>(lambda);
		}

		public static TM_SpecialityTypes Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<TM_SpecialityTypes>(new Paging { Page=page,RowCount=rowCount});
        }

        public static TM_SpecialityTypes Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<TM_SpecialityType, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<TM_SpecialityTypes>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<TM_SpecialityType>(exp,values)});
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
