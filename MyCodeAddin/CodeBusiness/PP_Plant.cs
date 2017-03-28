using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PP_Plant))]
#if Dev
    [RunLocal]
#endif

	public class PP_Plant:ReadOnlyBase<PP_Plant>
    {
        #region Business Methods

		
        public string Plant
        {
            get ;
            set ;
        }

		
        public string LText
        {
            get ;
            set ;
        }

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string BWKEY
        {
            get ;
            set ;
        }

		
        public string FABKL
        {
            get ;
            set ;
        }

		
        public string PurchaseGrp
        {
            get ;
            set ;
        }

		
        public string VKORG
        {
            get ;
            set ;
        }

		
        public string BEDPL
        {
            get ;
            set ;
        }

		
        public string Addr
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

		public static PP_Plant Create()
        {
            return EF.DataPortal.Create<PP_Plant>();
        }

		public static PP_Plant Fetch(System.Linq.Expressions.Expression<Func<PP_Plant, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PP_Plant>(exp,values);
            return EF.DataPortal.Fetch<PP_Plant>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PP_Plants))]
#if Dev
    [RunLocal]
#endif
	
	public class PP_Plants:ReadOnlyListBase<PP_Plants,PP_Plant>
    {
        #region Factory Methods

        public static PP_Plants Fetch()
        {
            return EF.DataPortal.Fetch<PP_Plants>();
        }

		public static PP_Plants Fetch(System.Linq.Expressions.Expression<Func<PP_Plant, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PP_Plant>(exp,values);
            return EF.DataPortal.Fetch<PP_Plants>(lambda);
		}

		public static PP_Plants Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PP_Plants>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PP_Plants Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PP_Plant, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PP_Plants>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PP_Plant>(exp,values)});
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
