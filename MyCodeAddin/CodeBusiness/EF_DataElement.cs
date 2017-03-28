using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(EF_DataElement))]
#if Dev
    [RunLocal]
#endif

	public class EF_DataElement:ReadOnlyBase<EF_DataElement>
    {
        #region Business Methods

		
        public string DElement
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

		
        public bool RefDomX
        {
            get ;
            set ;
        }

		
        public string Domain
        {
            get ;
            set ;
        }

		
        public string SHlpName
        {
            get ;
            set ;
        }

		
        public string SHlpField
        {
            get ;
            set ;
        }

		
        public string Text_S
        {
            get ;
            set ;
        }

		
        public string Text_L
        {
            get ;
            set ;
        }

		
        public string HeadText
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

		public static EF_DataElement Create()
        {
            return EF.DataPortal.Create<EF_DataElement>();
        }

		public static EF_DataElement Fetch(System.Linq.Expressions.Expression<Func<EF_DataElement, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<EF_DataElement>(exp,values);
            return EF.DataPortal.Fetch<EF_DataElement>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(EF_DataElements))]
#if Dev
    [RunLocal]
#endif
	
	public class EF_DataElements:ReadOnlyListBase<EF_DataElements,EF_DataElement>
    {
        #region Factory Methods

        public static EF_DataElements Fetch()
        {
            return EF.DataPortal.Fetch<EF_DataElements>();
        }

		public static EF_DataElements Fetch(System.Linq.Expressions.Expression<Func<EF_DataElement, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<EF_DataElement>(exp,values);
            return EF.DataPortal.Fetch<EF_DataElements>(lambda);
		}

		public static EF_DataElements Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<EF_DataElements>(new Paging { Page=page,RowCount=rowCount});
        }

        public static EF_DataElements Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<EF_DataElement, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<EF_DataElements>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<EF_DataElement>(exp,values)});
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
