using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(CO_WorkType))]
#if Dev
    [RunLocal]
#endif

	public class CO_WorkType:ReadOnlyBase<CO_WorkType>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string WorkType
        {
            get ;
            set ;
        }

		
        public string UnitCode
        {
            get ;
            set ;
        }

		
        public string WorkTypeTYP
        {
            get ;
            set ;
        }

		
        public string CostCtrType
        {
            get ;
            set ;
        }

		
        public string CostElem
        {
            get ;
            set ;
        }

		
        public bool? SPRKZ
        {
            get ;
            set ;
        }

		
        public string KTEXT
        {
            get ;
            set ;
        }

		
        public string LTEXT
        {
            get ;
            set ;
        }

		
        public string CreatedUser
        {
            get ;
            set ;
        }

		
        public DateTime? CreatedDate
        {
            get ;
            set ;
        }

		
        public string ChangedUser
        {
            get ;
            set ;
        }

		
        public DateTime? ChangedDate
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static CO_WorkType Create()
        {
            return EF.DataPortal.Create<CO_WorkType>();
        }

		public static CO_WorkType Fetch(System.Linq.Expressions.Expression<Func<CO_WorkType, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<CO_WorkType>(exp,values);
            return EF.DataPortal.Fetch<CO_WorkType>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(CO_WorkTypes))]
#if Dev
    [RunLocal]
#endif
	
	public class CO_WorkTypes:ReadOnlyListBase<CO_WorkTypes,CO_WorkType>
    {
        #region Factory Methods

        public static CO_WorkTypes Fetch()
        {
            return EF.DataPortal.Fetch<CO_WorkTypes>();
        }

		public static CO_WorkTypes Fetch(System.Linq.Expressions.Expression<Func<CO_WorkType, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<CO_WorkType>(exp,values);
            return EF.DataPortal.Fetch<CO_WorkTypes>(lambda);
		}

		public static CO_WorkTypes Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<CO_WorkTypes>(new Paging { Page=page,RowCount=rowCount});
        }

        public static CO_WorkTypes Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<CO_WorkType, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<CO_WorkTypes>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<CO_WorkType>(exp,values)});
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
