using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(EF_BarObj))]
#if Dev
    [RunLocal]
#endif

	public class EF_BarObj:ReadOnlyBase<EF_BarObj>
    {
        #region Business Methods

		
        public string BarObject
        {
            get ;
            set ;
        }

		
        public string DText
        {
            get ;
            set ;
        }

		
        public bool Buffer
        {
            get ;
            set ;
        }

		
        public int BufferSize
        {
            get ;
            set ;
        }

		
        public int SerialLen
        {
            get ;
            set ;
        }

		
        public System.Data.Linq.Binary TimeStamp
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

		public static EF_BarObj Create()
        {
            return EF.DataPortal.Create<EF_BarObj>();
        }

		public static EF_BarObj Fetch(System.Linq.Expressions.Expression<Func<EF_BarObj, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<EF_BarObj>(exp,values);
            return EF.DataPortal.Fetch<EF_BarObj>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(EF_BarObjs))]
#if Dev
    [RunLocal]
#endif
	
	public class EF_BarObjs:ReadOnlyListBase<EF_BarObjs,EF_BarObj>
    {
        #region Factory Methods

        public static EF_BarObjs Fetch()
        {
            return EF.DataPortal.Fetch<EF_BarObjs>();
        }

		public static EF_BarObjs Fetch(System.Linq.Expressions.Expression<Func<EF_BarObj, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<EF_BarObj>(exp,values);
            return EF.DataPortal.Fetch<EF_BarObjs>(lambda);
		}

		public static EF_BarObjs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<EF_BarObjs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static EF_BarObjs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<EF_BarObj, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<EF_BarObjs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<EF_BarObj>(exp,values)});
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
