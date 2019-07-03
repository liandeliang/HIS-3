using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Printing;
using com.digitalwave.controls;
using iCareData;

namespace iCare
{
    /// <summary>
    /// ��ӡ�ʹ�����¼, �׽̡�
    /// </summary>
    public class clsIMR_CesareanRecordPrintTool_LJ : clsInpatMedRecPrintBase
    {
        public clsIMR_CesareanRecordPrintTool_LJ(string p_strTypeID)
            : base(p_strTypeID)
        {
            //
            // TODO: �ڴ˴����ӹ��캯���߼�
            //
        }

        protected override void m_mthSetPrintLineArr()
        {
            m_objPrintLineContext = new com.digitalwave.Utility.Controls.clsPrintContext(
                new com.digitalwave.Utility.Controls.clsPrintLineBase[]{
																		  new clsPrintPatientFixInfo("�ʹ���������¼",300),
																		   new clsPrintInPatCesareanRecordMain(),
                                                                           new clsPrint11()
//																		   new clsPrintInPatApgar(),
																	    // new  clsPrintInPatMedDocAndDate()
				                                                         //  new clsPrintInPatMedRecDiagnostic()
																	   });
        }
        //protected override void m_mthPrintTitleInfo(System.Drawing.Printing.PrintPageEventArgs e)
        //{}
        //protected override void m_mthPrintHeader(System.Drawing.Printing.PrintPageEventArgs e)
        //{
        //}

        #region ��ӡʵ��

        #region ��ӡ��һҳ�Ĺ̶�����
        /// <summary>
        /// ��ӡ��һҳ�Ĺ̶�����
        /// </summary>
        //        internal class clsPrintPatientFixInfo : clsIMR_PrintLineBase
        //        {
        //            private clsPrintRichTextContext m_objPrintContext = new clsPrintRichTextContext(Color.Black,new Font("",10));

        //            public override void m_mthPrintNextLine(ref int p_intPosY, System.Drawing.Graphics p_objGrp, System.Drawing.Font p_fntNormalText)
        //            {
        //                #region 
        ////				p_objGrp.DrawString("�ʹ���������¼",m_fotItemHead,Brushes.Black,m_intRecBaseX+250,p_intPosY - 10);
        ////		
        ////				p_intPosY += 20;
        ////				p_objGrp.DrawString("������"+ m_objPrintInfo.m_strPatientName,p_fntNormalText,Brushes.Black,m_intPatientInfoX+50,p_intPosY);
        ////				p_objGrp.DrawString("��¼���ڣ�"+(m_objContent==null ? "": m_objContent.m_dtmCreateDate.ToString(MDIParent.s_ObjRecordDateTimeInfo.m_strGetRecordTimeFormat("frmInPatientCaseHistory"))),p_fntNormalText,Brushes.Black,m_intPatientInfoX+350,p_intPosY);
        ////		
        ////				p_intPosY += 20;
        ////				p_objGrp.DrawString("���䣺"+(m_objPrintInfo==null ? "": m_objPrintInfo.m_strAge),p_fntNormalText,Brushes.Black,m_intPatientInfoX+50,p_intPosY);
        ////				p_objGrp.DrawString("��ʷ�ߺͿɿ��̶ȣ�"+(m_objContent==null ? "": m_objContent.m_strRepresentor+"," +m_objContent.m_strCredibility),p_fntNormalText,Brushes.Black,m_intPatientInfoX+350,p_intPosY);
        ////		
        ////				p_intPosY += 20;
        ////				p_objGrp.DrawString("�Ա�"+ m_objPrintInfo.m_strSex ,p_fntNormalText,Brushes.Black,m_intPatientInfoX+50,p_intPosY);	
        ////				p_objGrp.DrawString("�����أ�"+ m_objPrintInfo.m_strNativePlace ,p_fntNormalText,Brushes.Black,m_intPatientInfoX+350,p_intPosY);			
        ////
        ////				p_intPosY += 20;
        ////				p_objGrp.DrawString("���ţ�"+m_objPrintInfo.m_strAreaName+m_objPrintInfo.m_strBedName ,p_fntNormalText,Brushes.Black,m_intPatientInfoX+50,p_intPosY);
        ////				p_objGrp.DrawString("סԺ�ţ�"+ m_objPrintInfo.m_strInPatientID ,p_fntNormalText,Brushes.Black,m_intPatientInfoX+350,p_intPosY);
        ////		
        ////				p_intPosY += 20;
        ////				p_objGrp.DrawString("ְҵ��"+ m_objPrintInfo.m_strOccupation ,p_fntNormalText,Brushes.Black,m_intPatientInfoX+50,p_intPosY);
        ////				p_objGrp.DrawString("��ϵ�ˣ�"+m_objPrintInfo.m_strLinkManFirstName ,p_fntNormalText,Brushes.Black,m_intPatientInfoX+350,p_intPosY);
        ////		
        ////				p_intPosY += 20;
        ////				p_objGrp.DrawString("������"+ m_objPrintInfo.m_strMarried,p_fntNormalText,Brushes.Black,m_intPatientInfoX+50,p_intPosY);
        ////				p_objGrp.DrawString("�绰��"+ m_objPrintInfo.m_strHomePhone ,p_fntNormalText,Brushes.Black,m_intPatientInfoX+350,p_intPosY);
        ////
        ////				p_intPosY += 20;
        ////				p_objGrp.DrawString("���壺"+ m_objPrintInfo.m_strNationality ,p_fntNormalText,Brushes.Black,m_intPatientInfoX+50,p_intPosY);
        ////				p_objGrp.DrawString("������λ��"+ m_objPrintInfo.m_strOfficeName ,p_fntNormalText,Brushes.Black,m_intPatientInfoX+350,p_intPosY);	
        ////		
        ////				p_intPosY += 20;
        ////				if(m_objPrintInfo.m_dtmInPatientDate != DateTime.MinValue)
        ////				{
        ////					p_objGrp.DrawString("��Ժ���ڣ�"+ m_objPrintInfo.m_dtmInPatientDate.ToString("yyyy��MM��dd�� HHʱ"),p_fntNormalText,Brushes.Black,m_intPatientInfoX+50,p_intPosY);			
        ////				}
        ////				else
        ////				{
        ////					p_objGrp.DrawString("��Ժ���ڣ�",p_fntNormalText,Brushes.Black,m_intPatientInfoX+50,p_intPosY);
        ////				}				
        ////			
        ////				m_objPrintContext.m_mthSetContextWithAllCorrect("סַ��"+ m_objPrintInfo.m_strHomeAddress ,"<root />");
        ////				int intRealHeight;
        ////				Rectangle rtgBlock = new Rectangle(m_intPatientInfoX+350,p_intPosY,(int)enmRectangleInfo.RightX-(m_intPatientInfoX+350),30);
        ////				m_objPrintContext.m_blnPrintAllBySimSun(11,rtgBlock,p_objGrp,out intRealHeight,false);
        ////								
        ////				p_intPosY += 30;
        ////				m_blnHaveMoreLine = false;
        //                #endregion
        //                p_objGrp.DrawString(clsSystemContext.s_ObjCurrentContext.m_ObjHospitalInfo.m_StrHospitalTitle,m_fotItemHead ,Brushes.Black,340,40);

        //                p_objGrp.DrawString("�ʹ���������¼",new Font("SimSun", 16,FontStyle.Bold),Brushes.Black,358,70);

        ////				p_objGrp.DrawString("���ţ�"+m_objPrintInfo.m_strAreaName+m_objPrintInfo.m_strBedName ,p_fntNormalText,Brushes.Black,350,110);
        ////				p_objGrp.DrawString("ĸ��סԺ�ţ�",p_fntNormalText,Brushes.Black,550,110);
        //                //p_objGrp.DrawString(m_objPrintInfo.m_strInPatientID ,p_fntNormalText,Brushes.Black,680,110);	
        //                p_intPosY =130;
        //                m_blnHaveMoreLine = false;
        //            }

        //            public override void m_mthReset()
        //            {
        //                m_objPrintContext.m_mthRestartPrint();

        //                m_blnHaveMoreLine = true;
        //            }
        //        }

        #endregion

        #region ��������---��ǰ�������
        /// <summary>
        /// ��������---��ǰ�������
        /// </summary>
        #endregion
        private class clsPrintInPatCesareanRecordMain : clsIMR_PrintLineBase
        {
            private clsPrintRichTextContext m_objPrintContext = new clsPrintRichTextContext(Color.Black, new Font("", 10));

            private Font m_fontItemMidHead = new Font("", 12, FontStyle.Bold);
            /// <summary>
            /// ��ͬ������ֻ��ӡһ��(�������״δ�ӡʱ���Ӧ��m_blnIsFirstPrint)
            /// </summary>
            private bool m_blnIsFirstPrint = true;

            private string[] m_strKeysArr1 = { "��������", "��������>>��" };


            public override void m_mthPrintNextLine(ref int p_intPosY, System.Drawing.Graphics p_objGrp, System.Drawing.Font p_fntNormalText)
            {
                if (m_objContent == null || m_objContent.m_objItemContents == null)
                {
                    m_blnHaveMoreLine = false;
                    return;
                }
                if (m_blnHavePrintInfo(m_strKeysArr1) == false)
                {
                    m_blnHaveMoreLine = false;
                    return;
                }
                if (m_blnIsFirstPrint)
                {
                    string strIsTime;
                    string strTime = "#";
                    string strAllText = "";
                    string strXml = "";
                    string strFirstName = new clsEmployee(m_objContent.m_strCreateUserID).m_StrFirstName;
                    if (m_objContent != null)
                    {
                        //m_mthMakeText(new string[]{"������"+(m_objPrintInfo==null ? "": m_objPrintInfo.m_strPatientName)+"��","              ���䣺"+(m_objPrintInfo==null ? "": m_objPrintInfo.m_strAge)+"��"},new string [] {"",""},ref strAllText,ref strXml);

                        //m_mthMakeText(new string[]{"   ���䣺"},new string []{"(m_objPrintInfo==null ? : m_objPrintInfo.m_strAge)"},ref strAllText,ref strXml);
                        //m_mthMakeText(new string[]{"              ���ţ�"+m_objPrintInfo.m_strAreaName+m_objPrintInfo.m_strBedName+""},new string []{""},ref strAllText,ref strXml);
                        //m_mthMakeText(new string[]{"                  סԺ�ţ�"+m_objPrintInfo.m_strInPatientID+""},new string []{""},ref strAllText,ref strXml);
                        //						m_mthMakeText(new string[]{"������"},new string []{"m_objPrintInfo.m_strPatientName"},ref strAllText,ref strXml);
                        //						m_mthMakeText(new string[]{"   ���䣺"},new string []{"(m_objPrintInfo==null ? : m_objPrintInfo.m_strAge)"},ref strAllText,ref strXml);
                        //						m_mthMakeText(new string[]{"   ���ţ�"},new string []{"m_objPrintInfo.m_strAreaName+m_objPrintInfo.m_strBedName"},ref strAllText,ref strXml);
                        //						m_mthMakeText(new string[]{"   סԺ�ţ�"},new string []{"m_objPrintInfo.m_strInPatientID"},ref strAllText,ref strXml);
                        m_mthMakeText(new string[] { "\n�������ڣ�", "    ��   $$" }, m_strKeysArr1, ref strAllText, ref strXml);

                        m_mthMakeText(new string[] { "\n��ǰ��ϣ�", "\n����ָ����", "\n�������ƣ�", "\n������ϣ�" }, new string[] { "��ǰ���", "����ָ��", "��������", "�������" }, ref strAllText, ref strXml);


                        m_mthMakeText(new string[] { "\n�����ߣ�", " ��һ���֣�", " �ڶ����֣�", " �������֣�", "\n����������", "��ҩ��������", "Ч����", "����ʦ��", "��еʿ��", "\n�пڲ�λ����ʽ��", "�пڳ��ȣ�", "����֬�����", "cm; ��Ĥ�⣺$$", "  ��Ĥ����" },
                            new string[] { "������", "��һ����", "�ڶ�����", "��������", "��������", "��ҩ������", "Ч��", "����ʦ", "��еʿ", "�пڲ�λ����ʽ", "�пڳ���", "����֬�����", "", "" }, ref strAllText, ref strXml);
                        m_mthMakeCheckText(new string[] { "", "��Ĥ����>>����", "��Ĥ����>>˳��" }, ref strAllText, ref strXml);

                        m_mthMakeText(new string[] { "\n��ǻ�����" }, new string[] { "" }, ref strAllText, ref strXml);
                        m_mthMakeCheckText(new string[] { "", "��ǻ���>>�и�ˮ", "��ǻ���>>�޸�ˮ" }, ref strAllText, ref strXml);
                        m_mthMakeText(new string[] { "��ˮ����$$", "ɫ", "��", "ճ�����", "\n�ӹ������", "�����¶ξ�������", "��ɫ", "��ƫ", "   ���ư��ף�" },
                            new string[] { "��ǻ���>>��ˮ��", "��ǻ���>>ɫ", "��ǻ���>>��", "��ǻ���>>ճ�����", "", "�ӹ����>>�����¶ξ�������", "�ӹ����>>��ɫ", "�ӹ����>>��ƫ", "" }, ref strAllText, ref strXml);

                        m_mthMakeCheckText(new string[] { "", "�ӹ����>>���ư���>>����", "�ӹ����>>���ư���>>˳��" }, ref strAllText, ref strXml);
                        m_mthMakeText(new string[] { "\n�ӹ��пڣ�" }, new string[] { "" }, ref strAllText, ref strXml);
                        m_mthMakeCheckText(new string[] { "", "�ӹ��п�>>����", "�ӹ��п�>>�¶�", "�ӹ��п�>>��", "�ӹ��п�>>˺" }, ref strAllText, ref strXml);
                        m_mthMakeText(new string[] { "$$", " �γ�", "cm; $$", "��", "cm; $$", " ˺��", " λ��", " ����", "cm$$", "\n�п��ӹ�������", "̥��λ", " �п��¼���", " ��ˮ��", "ml; $$", " ��״", "\n�������̥���Ĺ��̣�", " ���̥��", "��$$" },
                                      new string[] { "�ӹ��п�>>1", "�ӹ��п�>>�γ�", "", "�ӹ��п�>>��", "", "�ӹ��п�>>˺��", "�ӹ��п�>>λ��", "�ӹ��п�>>����", "", "", "�п��ӹ�����>>̥��λ", "�п��ӹ�����>>�п��¼�", "�п��ӹ�����>>��ˮ��", "", "�п��ӹ�����>>��״", "", "�������̥���Ĺ���>>���̥��", "" }, ref strAllText, ref strXml);

                        m_mthMakeCheckText(new string[] { "", "���̥��>>��", "���̥��>>��" }, ref strAllText, ref strXml);
                        m_mthMakeCheckText(new string[] { "������", "�������̥���Ĺ���>>����>>��ǯ", "�������̥���Ĺ���>>����>>̥��" }, ref strAllText, ref strXml);
                        m_mthMakeCheckText(new string[] { "�ַ���", "�������̥���Ĺ���>>�ַ�>>��ѹ����", "�������̥���Ĺ���>>�ַ�>>��������¶" }, ref strAllText, ref strXml);

                        m_mthMakeText(new string[] { "\n̥����������" }, new string[] { "" }, ref strAllText, ref strXml);
                        m_mthMakeCheckText(new string[] { "\n              ̥�̣�", "̥��������̥��>>����", "̥��������̥��>>�˹�����", "̥��������̥��>>�˹�����>>����", "̥��������̥��>>�˹�����>>������", "̥��������̥��>>��Ⱦ" }, ref strAllText, ref strXml);
                        m_mthMakeCheckText(new string[] { "   ̥Ĥ��", "̥��������>>̥Ĥ>>����", "̥��������>>̥Ĥ>>������" }, ref strAllText, ref strXml);
                        m_mthMakeText(new string[] { "�����", "����", "g; $$", "����", "\n              �������", "cm��$$" },
                            new string[] { "̥��������>>̥Ĥ>>���", "̥��������>>̥Ĥ>>����", "", "̥��������>>̥Ĥ>>������", "̥��������>>�����", "" }, ref strAllText, ref strXml);

                        m_mthMakeCheckText(new string[] { "", "̥��������>>���>>�ƾ�", "̥��������>>���>>����", "̥��������>>���>>����" }, ref strAllText, ref strXml);
                        m_mthMakeText(new string[] { "$$", "�ܣ�$$" }, new string[] { "̥��������>>���>>��", "" }, ref strAllText, ref strXml);
                        m_mthMakeCheckText(new string[] { "", "̥��������>>���>>���", "̥��������>>���>>�ٽ�", "̥��������>>���>>��", "̥��������>>���>>��" }, ref strAllText, ref strXml);
                        m_mthMakeText(new string[] { "Ťת", "�ܣ�$$", "������" }, new string[] { "̥��������>>���>>Ťת>>��", "", "̥��������>>���>>����" }, ref strAllText, ref strXml);

                        m_mthMakeCheckText(new string[] { "\n����Ӥ�������", "����Ӥ�����>>��", "����Ӥ�����>>Ů" }, ref strAllText, ref strXml);
                        m_mthMakeText(new string[] { "Apgar����1'��", "5'��", "����", "#g$$" },
                            new string[] { "����Ӥ�����>>����1'", "����Ӥ�����>>5'", "����Ӥ�����>>����", "����Ӥ�����>>����" }, ref strAllText, ref strXml);
                        m_mthMakeCheckText(new string[] { "  ���ȣ�", "����>>��̵", "����>>���", "����>>����" }, ref strAllText, ref strXml);

                        if (m_hasItems.ContainsKey("����Ӥ�����>>�Ƿ�ת����ʱ��"))
                        {
                            //�Ƿ�ѡ��ת����ʱ��
                            strIsTime = ((clsInpatMedRec_Item)m_hasItems["����Ӥ�����>>�Ƿ�ת����ʱ��"]).m_strItemContent;
                            //�����ѡ��ת����ʱ�䣬�򲻴�ӡת����ʱ��
                            if (strIsTime == "True")
                                strTime = "ת����ʱ�䣺";
                        }
                        base.m_strDateType = "yyyy-MM-dd HH:mm:ss";
                        m_mthMakeText(new string[] { strTime, "\n�ӹ��ڷ�ϣ�", "��", "�㣻��$$", "��$$", "��$$", "���$$", "������ $$", "��ʽ:", "\n��ϰ��׸�Ĥ���ۣ�" },
                            new string[] { "����Ӥ�����>>ת����ʱ��", "", "�ӹ��ڷ��>>��", "�ӹ��ڷ��>>��", "�ӹ��ڷ��>>��", "�ӹ��ڷ��>>���", "�ӹ��ڷ��>>����", "", "�ӹ��ڷ��>>��ʽ", "��ϰ��׸�Ĥ����" }, ref strAllText, ref strXml);

                        m_mthMakeCheckText(new string[] { "\n  �ӹ�������", "�ӹ�����>>��", "�ӹ�����>>Ƿ��", "�ӹ�����>>��" }, ref strAllText, ref strXml);

                        m_mthMakeText(new string[] { "    ������ҩ��", "��:", "\n��ǻ̽�飺", "�ӹ���", "\n                      ������", "\n����������", "\n���ڷ�ϣ�", "���ڷ���ã�", "�ţ�$$", "�� $$", " $$" },
                            new string[] { "������ҩ", "������ҩ>>��", "", "��ǻ̽��>>�ӹ�", "��ǻ̽��>>����", "��������", "", "���ڷ��>>���ڷ��>>��", "���ڷ��>>���ڷ��>>��", "���ڷ��>>���ڷ��>>���", "" }, ref strAllText, ref strXml);

                        #region ���ڷ��
                        m_mthMakeCheckText(new string[] { "  ���  ", "���ڷ��>>���ڷ��>>����", "���ڷ��>>���ڷ��>>���" }, ref strAllText, ref strXml);
                        m_mthMakeText(new string[] { "\n                     ��ֱ����Ĥ�ã�", "�ţ�$$", "�� $$", " $$" }, new string[] { "���ڷ��>>��ֱ����Ĥ>>��", "���ڷ��>>��ֱ����Ĥ>>��", "���ڷ��>>��ֱ����Ĥ>>���", "" }, ref strAllText, ref strXml);
                        m_mthMakeCheckText(new string[] { "  ���  ", "���ڷ��>>��ֱ����Ĥ>>����", "���ڷ��>>��ֱ����Ĥ>>���" }, ref strAllText, ref strXml);
                        m_mthMakeText(new string[] { "\n                     ֬�����ã�", "�ţ�$$", "�� $$", " ���$$", "�룻$$", "\n                     Ƥ���ã�", "�ţ�$$", "�� $$", " $$" },
                            new string[] { "���ڷ��>>֬����>>��", "���ڷ��>>֬����>>��", "���ڷ��>>֬����>>��", "���ڷ��>>֬����>>��", "", "Ƥ��>>��", "Ƥ��>>��", "Ƥ��>>���", "" }, ref strAllText, ref strXml);
                        m_mthMakeCheckText(new string[] { "  ���  ", "���ڷ��>>Ƥ��>>���", "���ڷ��>>Ƥ��>>���" }, ref strAllText, ref strXml);
                        #endregion ���ڷ��
                        #region ����ʱ�������
                        m_mthMakeText(new string[] { "\n����ʱ���������" }, new string[] { "" }, ref strAllText, ref strXml);
                        m_mthMakeCheckText(new string[] { "", "����ʱ�������>>����", "����ʱ�������>>����", "����ʱ�������>>����", "����ʱ�������>>�ȶ�", "����ʱ�������>>�ݿ�" }, ref strAllText, ref strXml);
                        m_mthMakeText(new string[] { "", "\n��������ʱ��ʧѪ����", "ml:$$", "\n��ʱ��Һ��:", "ml;$$", "  ��Ѫ�ɷݣ�", "��λ", "  ��Ѫ��:", "ml;$$", " ������", "Сʱ��$$", "  ����Ѫѹ��", "mmHg��$$", "\n������ҩ��", " \n�Ͳ����걾���ƣ�", "  ��������", "ml��$$", "  ɫ", "\n�����е���������", "  �������" },
                            new string[] { "����ʱ�������>>�ݿ����", "��������ʱ��ʧѧ��", "", "��ʱ��Һ��", "", "��Ѫ�ɷ�", "", "��Ѫ��", "", "����", "", "����Ѫѹ", "", "������ҩ", "�Ͳ����걾����", "��������", "", "������>>ɫ", "�����е�������", "�������" }, ref strAllText, ref strXml);

                        #endregion ����ʱ�������


                    }
                    else
                    {
                        m_blnHaveMoreLine = false;
                        return;
                    }
                    m_objPrintContext.m_mthSetContextWithCorrectBefore(strAllText, strXml, m_dtmFirstPrintTime, m_objContent.m_objItemContents != null);
                    //m_mthAddSign2("������Σ�",m_objPrintContext.m_ObjModifyUserArr);
                    m_blnIsFirstPrint = false;
                }

                if (m_objPrintContext.m_BlnHaveNextLine())
                {
                    m_objPrintContext.m_mthPrintLine((int)enmRectangleInfoInPatientCaseInfo.PrintWidth2, m_intRecBaseX + 10, p_intPosY, p_objGrp);
                    p_intPosY += 20;
                }
                if (m_objPrintContext.m_BlnHaveNextLine())
                {
                    m_blnHaveMoreLine = true;
                }
                else
                {
                    m_blnHaveMoreLine = false;
                }
            }

            public override void m_mthReset()
            {
                m_objPrintContext.m_mthRestartPrint();
                m_blnHaveMoreLine = true;
                m_blnIsFirstPrint = true;
            }
        }

        #region ��ӡǩ��
        /// <summary>
        /// ǩ��
        /// </summary>
        private class clsPrint11 : clsIMR_PrintLineBase
        {
            private clsPrintRichTextContext m_objPrintContext = new clsPrintRichTextContext(Color.Black, new Font("", 10));
            /// <summary>
            /// ��ͬ������ֻ��ӡһ��(�������״δ�ӡʱ���Ӧ��m_blnIsFirstPrint)
            /// </summary>
            private bool m_blnIsFirstPrint = true;
            private clsInpatMedRec_Item objItemContent = null;
            public override void m_mthPrintNextLine(ref int p_intPosY, System.Drawing.Graphics p_objGrp, System.Drawing.Font p_fntNormalText)
            {
                if (m_objContent == null || m_objContent.m_objItemContents == null)
                {
                    m_blnHaveMoreLine = false;
                    return;
                }
                if (m_blnIsFirstPrint)
                {
                    p_intPosY += 20;
                    string strHelpers = "";
                    string strAllText = "";
                    string strXml = "";
                    for (int i = 0; i < m_objContent.objSignerArr.Length; i++)
                    {
                        if (m_objContent.objSignerArr[i].controlName == "m_lsvOperation")
                            strHelpers += m_objContent.objSignerArr[i].objEmployee.m_strGetTechnicalRankAndName + "   ";
                    }
                    if (strHelpers != "")
                    {
                        p_objGrp.DrawString("ǩ����", p_fntNormalText, Brushes.Black, m_intRecBaseX + 10, p_intPosY);

                        string strFirstName = new clsEmployee(m_objContent.m_strCreateUserID).m_StrFirstName;
                        m_mthMakeText(new string[] { strHelpers }, new string[] { "" }, ref strAllText, ref strXml);
                    }
                    else
                    {
                        m_blnHaveMoreLine = false;
                        return;
                    }
                    m_objPrintContext.m_mthSetContextWithCorrectBefore(strAllText, strXml, m_dtmFirstPrintTime, m_objContent.m_objItemContents != null);
                    m_blnIsFirstPrint = false;
                }

                if (m_objPrintContext.m_BlnHaveNextLine())
                {
                    m_objPrintContext.m_mthPrintLine((int)enmRectangleInfoInPatientCaseInfo.PrintWidth2 - 25, m_intRecBaseX + 60, p_intPosY, p_objGrp);
                    p_intPosY += 20;
                }
                if (m_objPrintContext.m_BlnHaveNextLine())
                {
                    m_blnHaveMoreLine = true;
                }
                else
                {
                    m_blnHaveMoreLine = false;
                }
            }

            public override void m_mthReset()
            {
                m_objPrintContext.m_mthRestartPrint();
                m_blnHaveMoreLine = true;
                m_blnIsFirstPrint = true;
            }
        }

        #endregion
        #region ָӡ����ҽʦ����¼����
        //		/// <summary>
        //		///  ָӡ����ҽʦ����¼����
        //		/// </summary>
        //		private class clsPrintInPatMedDocAndDate : clsIMR_PrintLineBase
        //		{
        //			private clsPrintRichTextContext m_objPrintContext = new clsPrintRichTextContext(Color.Black,new Font("",10));
        //
        //			private Font m_fontItemMidHead = new Font("",12,FontStyle.Bold);
        //			/// <summary>
        //			/// ��ͬ������ֻ��ӡһ��(�������״δ�ӡʱ���Ӧ��m_blnIsFirstPrint)
        //			/// </summary>
        //			private bool m_blnIsFirstPrint = true;
        //			private bool blnNextPage = true;
        //			private string[] m_strKeysArr1 = {"ǩ��"};
        //			//private string[] m_strKeysArr2 = {"��¼����"};
        //			
        //			public override void m_mthPrintNextLine(ref int p_intPosY, System.Drawing.Graphics p_objGrp, System.Drawing.Font p_fntNormalText)
        //			{
        //				if(m_objContent == null|| m_objContent.m_objItemContents == null)
        //				{
        //					m_blnHaveMoreLine = false;
        //					return;
        //				}
        //				//if(m_blnHavePrintInfo(m_strKeysArr1) == false && m_blnHavePrintInfo(m_strKeysArr2) == false )
        //				
        //				if(m_blnHavePrintInfo(m_strKeysArr1) == false  )
        //				{
        //					m_blnHaveMoreLine = false;
        //					return;
        //				}
        //				//				if(blnNextPage)
        //				//				{
        //				//					//����һҳ��ӡ�����ô�ӡʱ���p_intPosY�Ƿ������ױߵ�ֵ���ж���ʵ��
        //				//					m_blnHaveMoreLine = true;
        //				//					blnNextPage = false;
        //				//					p_intPosY += 1500;
        //				//					return;
        //				//				}
        //				if(m_blnIsFirstPrint)
        //				{
        //					//					p_objGrp.DrawString("��ϵͳ���",m_fotItemHead,Brushes.Black,m_intRecBaseX+310,p_intPosY);
        //					//					p_intPosY += 20;
        //					//					p_objGrp.DrawString("һ�����",m_fontItemMidHead,Brushes.Black,m_intRecBaseX,p_intPosY);
        //					//					p_intPosY += 20;
        //					string strAllText = "";
        //					string strXml = "";
        //					string strFirstName = new clsEmployee(m_objContent.m_strCreateUserID).m_StrFirstName;
        //					if(m_objContent!=null)
        //					{
        //						if(m_blnHavePrintInfo(m_strKeysArr1) != false)
        //							m_mthMakeText(new string[]{"ǩ����"},m_strKeysArr1,ref strAllText,ref strXml);
        ////						if(m_blnHavePrintInfo(m_strKeysArr2) != false)
        ////							m_mthMakeText(new string[]{"\n��¼����"},m_strKeysArr2,ref strAllText,ref strXml);
        //						
        //					}
        //					else
        //					{
        //						m_blnHaveMoreLine = false;
        //						return;
        //					}
        //					m_objPrintContext.m_mthSetContextWithCorrectBefore(strAllText,strXml,m_dtmFirstPrintTime,m_objContent.m_objItemContents!= null);
        ////					m_mthAddSign2("ҽ��ǩ�֣�",m_objPrintContext.m_ObjModifyUserArr);
        //					
        //				//	m_mthAddSign2("ǩ����",m_objPrintContext.m_ObjModifyUserArr);
        //					m_blnIsFirstPrint = false;					
        //				}
        //
        //				int intLine = 0;
        //				if(m_objPrintContext.m_BlnHaveNextLine())
        //				{
        //					m_objPrintContext.m_mthPrintLine((int)enmRectangleInfoInPatientCaseInfo.PrintWidth2,m_intRecBaseX+10,p_intPosY,p_objGrp);
        //					p_intPosY += 20;
        //				}
        //				if(m_objPrintContext.m_BlnHaveNextLine())
        //				{
        //					m_blnHaveMoreLine = true;
        //				}
        //				else
        //				{
        //					m_blnHaveMoreLine = false;
        //				}
        //			}
        //
        //			public override void m_mthReset()
        //			{
        //				m_objPrintContext.m_mthRestartPrint();
        //				m_blnHaveMoreLine = true;
        //				m_blnIsFirstPrint = true;
        //			}
        //		}
        #endregion
        #region �������&������ϣ���ϣ�
        /// <summary>
        /// �������&������ϣ���ϣ�
        /// </summary>
        //private class clsPrintInPatMedRecDiagnostic : clsIMR_PrintLineBase
        //{
        //    private Font m_fontItemMidHead = new Font("", 12, FontStyle.Bold);
        //    private clsPrintRichTextContext m_objPrintContext1 = new clsPrintRichTextContext(Color.Black, new Font("", 10));
        //    private clsPrintRichTextContext m_objPrintContext2 = new clsPrintRichTextContext(Color.Black, new Font("", 10));

        //    private clsInpatMedRec_Item[] objItemContent;
        //    /// <summary>
        //    /// ��ͬ������ֻ��ӡһ��(�������״δ�ӡʱ���Ӧ��m_blnIsFirstPrint)
        //    /// </summary>
        //    private bool m_blnIsFirstPrint = true;
        //    public override void m_mthPrintNextLine(ref int p_intPosY, System.Drawing.Graphics p_objGrp, System.Drawing.Font p_fntNormalText)
        //    {
        //        objItemContent = m_objGetContentFromItemArr(new string[] { "�������", "�������", "ǩ��", "ǩ��" });
        //        if (objItemContent == null || (objItemContent[0] == null && objItemContent[1] == null))
        //        {
        //            m_mthPrintSign(ref p_intPosY, p_objGrp, p_fntNormalText);
        //            m_blnHaveMoreLine = false;
        //            return;
        //        }
        //        if (m_blnIsFirstPrint)
        //        {
        //            if (objItemContent[0] != null)
        //                if (objItemContent[0].m_strItemContent != null)
        //                    p_objGrp.DrawString("������ϣ�", m_fontItemMidHead, Brushes.Black, m_intRecBaseX + 10, p_intPosY);
        //            if (objItemContent[1] != null)
        //                if (objItemContent[1].m_strItemContent != null)
        //                    p_objGrp.DrawString("������ϣ�", m_fontItemMidHead, Brushes.Black, m_intRecBaseX + 380, p_intPosY);
        //            p_intPosY += 20;
        //            if (objItemContent[0] != null)
        //                if (objItemContent[0].m_strItemContent != null)
        //                {
        //                    m_objPrintContext1.m_mthSetContextWithCorrectBefore(objItemContent[0].m_strItemContent, (objItemContent[0] == null ? "<root />" : objItemContent[0].m_strItemContentXml), m_dtmFirstPrintTime, objItemContent[0] != null);
        //                    m_mthAddSign2("������ϣ�", m_objPrintContext1.m_ObjModifyUserArr);
        //                }
        //            if (objItemContent[1] != null)
        //                if (objItemContent[1].m_strItemContent != null)
        //                {
        //                    m_objPrintContext2.m_mthSetContextWithCorrectBefore(objItemContent[1].m_strItemContent, (objItemContent[1] == null ? "<root />" : objItemContent[1].m_strItemContentXml), m_dtmFirstPrintTime, objItemContent[1] != null);
        //                    m_mthAddSign2("������ϣ�", m_objPrintContext2.m_ObjModifyUserArr);
        //                }
        //            m_blnIsFirstPrint = false;
        //        }

        //        int intLine = 0;
        //        if (m_objPrintContext1.m_BlnHaveNextLine() || m_objPrintContext2.m_BlnHaveNextLine())
        //        {
        //            if (objItemContent[0] != null)
        //                if (objItemContent[0].m_strItemContent != null)
        //                    m_objPrintContext1.m_mthPrintLine(320, m_intRecBaseX + 30, p_intPosY, p_objGrp);
        //            if (objItemContent[1] != null)
        //                if (objItemContent[1].m_strItemContent != null)
        //                    m_objPrintContext2.m_mthPrintLine(330, m_intRecBaseX + 400, p_intPosY, p_objGrp);
        //            p_intPosY += 20;
        //            intLine++;
        //        }

        //        if (m_objPrintContext1.m_BlnHaveNextLine() || m_objPrintContext2.m_BlnHaveNextLine())
        //            m_blnHaveMoreLine = true;
        //        else
        //        {
        //            p_intPosY += 20;
        //            m_mthPrintSign(ref p_intPosY, p_objGrp, p_fntNormalText);
        //            m_blnHaveMoreLine = false;
        //        }
        //    }

        //    private void m_mthPrintSign(ref int p_intPosY, System.Drawing.Graphics p_objGrp, System.Drawing.Font p_fntNormalText)
        //    {
        //        if (m_hasItems == null)
        //            return;
        //        p_intPosY += 20;
        //        //p_objGrp.DrawString("ǩ����"+(objItemContent[2]==null ? "" : (objItemContent[2].m_strItemContent == null ? "":objItemContent[2].m_strItemContent)) ,m_fontItemMidHead,Brushes.Black,m_intRecBaseX+20,p_intPosY);
        //        p_objGrp.DrawString("ǩ����" + (objItemContent[3] == null ? "" : (objItemContent[3].m_strItemContent == null ? "" : objItemContent[3].m_strItemContent)), m_fontItemMidHead, Brushes.Black, m_intRecBaseX + 450, p_intPosY);

        //    }

        //    public override void m_mthReset()
        //    {
        //        m_objPrintContext1.m_mthRestartPrint();
        //        m_objPrintContext2.m_mthRestartPrint();
        //        m_blnHaveMoreLine = true;
        //        m_blnIsFirstPrint = true;
        //    }
        //}
        #endregion

        #endregion
    }
}