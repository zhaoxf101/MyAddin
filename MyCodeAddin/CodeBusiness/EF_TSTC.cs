using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(EF_TSTC))]
#if Dev
    [RunLocal]
#endif

	public class EF_TSTC:ReadOnlyBase<EF_TSTC>
    {
        #region Business Methods

		
        public string TCode
        {
            get ;
            set ;
        }

		
        public string UIType
        {
            get ;
            set ;
        }

		
        public string DText
        {
            get ;
            set ;
        }

		
        public string PgmName
        {
            get ;
            set ;
        }

		
        public string WebURL
        {
            get ;
            set ;
        }

		
        public bool Share
        {
            get ;
            set ;
        }

		
        public string CallParams
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

		public static EF_TSTC Create()
        {
            return EF.DataPortal.Create<EF_TSTC>();
        }

		public static EF_TSTC Fetch(System.Linq.Expressions.Expression<Func<EF_TSTC, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<EF_TSTC>(exp,values);
            return EF.DataPortal.Fetch<EF_TSTC>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(EF_TSTCs))]
#if Dev
    [RunLocal]
#endif
	
	public class EF_TSTCs:ReadOnlyListBase<EF_TSTCs,EF_TSTC>
    {
        #region Factory Methods

        public static EF_TSTCs Fetch()
        {
            return EF.DataPortal.Fetch<EF_TSTCs>();
        }

		public static EF_TSTCs Fetch(System.Linq.Expressions.Expression<Func<EF_TSTC, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<EF_TSTC>(exp,values);
            return EF.DataPortal.Fetch<EF_TSTCs>(lambda);
		}

		public static EF_TSTCs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<EF_TSTCs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static EF_TSTCs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<EF_TSTC, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<EF_TSTCs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<EF_TSTC>(exp,values)});
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
