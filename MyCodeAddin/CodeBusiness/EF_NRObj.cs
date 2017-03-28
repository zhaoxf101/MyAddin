using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(EF_NRObj))]
#if Dev
    [RunLocal]
#endif

	public class EF_NRObj:ReadOnlyBase<EF_NRObj>
    {
        #region Business Methods

		
        public string NRObject
        {
            get ;
            set ;
        }

		
        public string DText
        {
            get ;
            set ;
        }

		
        public string PidType
        {
            get ;
            set ;
        }

		
        public bool PidToPrefix
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

		
        public bool Single
        {
            get ;
            set ;
        }

		
        public bool Reusable
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

		public static EF_NRObj Create()
        {
            return EF.DataPortal.Create<EF_NRObj>();
        }

		public static EF_NRObj Fetch(System.Linq.Expressions.Expression<Func<EF_NRObj, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<EF_NRObj>(exp,values);
            return EF.DataPortal.Fetch<EF_NRObj>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(EF_NRObjs))]
#if Dev
    [RunLocal]
#endif
	
	public class EF_NRObjs:ReadOnlyListBase<EF_NRObjs,EF_NRObj>
    {
        #region Factory Methods

        public static EF_NRObjs Fetch()
        {
            return EF.DataPortal.Fetch<EF_NRObjs>();
        }

		public static EF_NRObjs Fetch(System.Linq.Expressions.Expression<Func<EF_NRObj, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<EF_NRObj>(exp,values);
            return EF.DataPortal.Fetch<EF_NRObjs>(lambda);
		}

		public static EF_NRObjs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<EF_NRObjs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static EF_NRObjs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<EF_NRObj, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<EF_NRObjs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<EF_NRObj>(exp,values)});
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
