using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(EF_Domain))]
#if Dev
    [RunLocal]
#endif

	public class EF_Domain:ReadOnlyBase<EF_Domain>
    {
        #region Business Methods

		
        public string Domain
        {
            get ;
            set ;
        }

		
        public string RowStatus
        {
            get ;
            set ;
        }

		
        public string DText
        {
            get ;
            set ;
        }

		
        public string DataType
        {
            get ;
            set ;
        }

		
        public int Leng
        {
            get ;
            set ;
        }

		
        public int Decimals
        {
            get ;
            set ;
        }

		
        public bool NegFlagX
        {
            get ;
            set ;
        }

		
        public bool UpperCaseX
        {
            get ;
            set ;
        }

		
        public bool ValExiX
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

		public static EF_Domain Create()
        {
            return EF.DataPortal.Create<EF_Domain>();
        }

		public static EF_Domain Fetch(System.Linq.Expressions.Expression<Func<EF_Domain, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<EF_Domain>(exp,values);
            return EF.DataPortal.Fetch<EF_Domain>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(EF_Domains))]
#if Dev
    [RunLocal]
#endif
	
	public class EF_Domains:ReadOnlyListBase<EF_Domains,EF_Domain>
    {
        #region Factory Methods

        public static EF_Domains Fetch()
        {
            return EF.DataPortal.Fetch<EF_Domains>();
        }

		public static EF_Domains Fetch(System.Linq.Expressions.Expression<Func<EF_Domain, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<EF_Domain>(exp,values);
            return EF.DataPortal.Fetch<EF_Domains>(lambda);
		}

		public static EF_Domains Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<EF_Domains>(new Paging { Page=page,RowCount=rowCount});
        }

        public static EF_Domains Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<EF_Domain, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<EF_Domains>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<EF_Domain>(exp,values)});
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
