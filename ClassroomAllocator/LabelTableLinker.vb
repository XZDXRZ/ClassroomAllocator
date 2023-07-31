﻿Public Class LabelTableLinker
    ' A 2-dimensional array that connects the components on the form and a pair of number together
    Public lblTableLinker(9, 10) As Label

    Public Sub New()
        ' Initialize lblTableLinker, connecting a pair of number to a label on the form
        lblTableLinker(Period.TUTORIAL, Room.S01) = MasterForm.lblTutorialS01
        lblTableLinker(Period.TUTORIAL, Room.S02) = MasterForm.lblTutorialS02
        lblTableLinker(Period.TUTORIAL, Room.S03) = MasterForm.lblTutorialS03
        lblTableLinker(Period.TUTORIAL, Room.S04) = MasterForm.lblTutorialS04
        lblTableLinker(Period.TUTORIAL, Room.S05) = MasterForm.lblTutorialS05
        lblTableLinker(Period.TUTORIAL, Room.S06) = MasterForm.lblTutorialS06
        lblTableLinker(Period.TUTORIAL, Room.S07) = MasterForm.lblTutorialS07
        lblTableLinker(Period.TUTORIAL, Room.S08) = MasterForm.lblTutorialS08
        lblTableLinker(Period.TUTORIAL, Room.S09) = MasterForm.lblTutorialS09
        lblTableLinker(Period.TUTORIAL, Room.S10) = MasterForm.lblTutorialS10
        lblTableLinker(Period.PERIOD1, Room.S01) = MasterForm.lblPeriod1S01
        lblTableLinker(Period.PERIOD1, Room.S02) = MasterForm.lblPeriod1S02
        lblTableLinker(Period.PERIOD1, Room.S03) = MasterForm.lblPeriod1S03
        lblTableLinker(Period.PERIOD1, Room.S04) = MasterForm.lblPeriod1S04
        lblTableLinker(Period.PERIOD1, Room.S05) = MasterForm.lblPeriod1S05
        lblTableLinker(Period.PERIOD1, Room.S06) = MasterForm.lblPeriod1S06
        lblTableLinker(Period.PERIOD1, Room.S07) = MasterForm.lblPeriod1S07
        lblTableLinker(Period.PERIOD1, Room.S08) = MasterForm.lblPeriod1S08
        lblTableLinker(Period.PERIOD1, Room.S09) = MasterForm.lblPeriod1S09
        lblTableLinker(Period.PERIOD1, Room.S10) = MasterForm.lblPeriod1S10
        lblTableLinker(Period.PERIOD2, Room.S01) = MasterForm.lblPeriod2S01
        lblTableLinker(Period.PERIOD2, Room.S02) = MasterForm.lblPeriod2S02
        lblTableLinker(Period.PERIOD2, Room.S03) = MasterForm.lblPeriod2S03
        lblTableLinker(Period.PERIOD2, Room.S04) = MasterForm.lblPeriod2S04
        lblTableLinker(Period.PERIOD2, Room.S05) = MasterForm.lblPeriod2S05
        lblTableLinker(Period.PERIOD2, Room.S06) = MasterForm.lblPeriod2S06
        lblTableLinker(Period.PERIOD2, Room.S07) = MasterForm.lblPeriod2S07
        lblTableLinker(Period.PERIOD2, Room.S08) = MasterForm.lblPeriod2S08
        lblTableLinker(Period.PERIOD2, Room.S09) = MasterForm.lblPeriod2S09
        lblTableLinker(Period.PERIOD2, Room.S10) = MasterForm.lblPeriod2S10
        lblTableLinker(Period.RECESS, Room.S01) = MasterForm.lblRecessS01
        lblTableLinker(Period.RECESS, Room.S02) = MasterForm.lblRecessS02
        lblTableLinker(Period.RECESS, Room.S03) = MasterForm.lblRecessS03
        lblTableLinker(Period.RECESS, Room.S04) = MasterForm.lblRecessS04
        lblTableLinker(Period.RECESS, Room.S05) = MasterForm.lblRecessS05
        lblTableLinker(Period.RECESS, Room.S06) = MasterForm.lblRecessS06
        lblTableLinker(Period.RECESS, Room.S07) = MasterForm.lblRecessS07
        lblTableLinker(Period.RECESS, Room.S08) = MasterForm.lblRecessS08
        lblTableLinker(Period.RECESS, Room.S09) = MasterForm.lblRecessS09
        lblTableLinker(Period.RECESS, Room.S10) = MasterForm.lblRecessS10
        lblTableLinker(Period.PERIOD3, Room.S01) = MasterForm.lblPeriod3S01
        lblTableLinker(Period.PERIOD3, Room.S02) = MasterForm.lblPeriod3S02
        lblTableLinker(Period.PERIOD3, Room.S03) = MasterForm.lblPeriod3S03
        lblTableLinker(Period.PERIOD3, Room.S04) = MasterForm.lblPeriod3S04
        lblTableLinker(Period.PERIOD3, Room.S05) = MasterForm.lblPeriod3S05
        lblTableLinker(Period.PERIOD3, Room.S06) = MasterForm.lblPeriod3S06
        lblTableLinker(Period.PERIOD3, Room.S07) = MasterForm.lblPeriod3S07
        lblTableLinker(Period.PERIOD3, Room.S08) = MasterForm.lblPeriod3S08
        lblTableLinker(Period.PERIOD3, Room.S09) = MasterForm.lblPeriod3S09
        lblTableLinker(Period.PERIOD3, Room.S10) = MasterForm.lblPeriod3S10
        lblTableLinker(Period.PERIOD4, Room.S01) = MasterForm.lblPeriod4S01
        lblTableLinker(Period.PERIOD4, Room.S02) = MasterForm.lblPeriod4S02
        lblTableLinker(Period.PERIOD4, Room.S03) = MasterForm.lblPeriod4S03
        lblTableLinker(Period.PERIOD4, Room.S04) = MasterForm.lblPeriod4S04
        lblTableLinker(Period.PERIOD4, Room.S05) = MasterForm.lblPeriod4S05
        lblTableLinker(Period.PERIOD4, Room.S06) = MasterForm.lblPeriod4S06
        lblTableLinker(Period.PERIOD4, Room.S07) = MasterForm.lblPeriod4S07
        lblTableLinker(Period.PERIOD4, Room.S08) = MasterForm.lblPeriod4S08
        lblTableLinker(Period.PERIOD4, Room.S09) = MasterForm.lblPeriod4S09
        lblTableLinker(Period.PERIOD4, Room.S10) = MasterForm.lblPeriod4S10
        lblTableLinker(Period.LUNCH, Room.S01) = MasterForm.lblLunchS01
        lblTableLinker(Period.LUNCH, Room.S02) = MasterForm.lblLunchS02
        lblTableLinker(Period.LUNCH, Room.S03) = MasterForm.lblLunchS03
        lblTableLinker(Period.LUNCH, Room.S04) = MasterForm.lblLunchS04
        lblTableLinker(Period.LUNCH, Room.S05) = MasterForm.lblLunchS05
        lblTableLinker(Period.LUNCH, Room.S06) = MasterForm.lblLunchS06
        lblTableLinker(Period.LUNCH, Room.S07) = MasterForm.lblLunchS07
        lblTableLinker(Period.LUNCH, Room.S08) = MasterForm.lblLunchS08
        lblTableLinker(Period.LUNCH, Room.S09) = MasterForm.lblLunchS09
        lblTableLinker(Period.LUNCH, Room.S10) = MasterForm.lblLunchS10
        lblTableLinker(Period.PERIOD5, Room.S01) = MasterForm.lblPeriod5S01
        lblTableLinker(Period.PERIOD5, Room.S02) = MasterForm.lblPeriod5S02
        lblTableLinker(Period.PERIOD5, Room.S03) = MasterForm.lblPeriod5S03
        lblTableLinker(Period.PERIOD5, Room.S04) = MasterForm.lblPeriod5S04
        lblTableLinker(Period.PERIOD5, Room.S05) = MasterForm.lblPeriod5S05
        lblTableLinker(Period.PERIOD5, Room.S06) = MasterForm.lblPeriod5S06
        lblTableLinker(Period.PERIOD5, Room.S07) = MasterForm.lblPeriod5S07
        lblTableLinker(Period.PERIOD5, Room.S08) = MasterForm.lblPeriod5S08
        lblTableLinker(Period.PERIOD5, Room.S09) = MasterForm.lblPeriod5S09
        lblTableLinker(Period.PERIOD5, Room.S10) = MasterForm.lblPeriod5S10
        lblTableLinker(Period.PERIOD6, Room.S01) = MasterForm.lblPeriod6S01
        lblTableLinker(Period.PERIOD6, Room.S02) = MasterForm.lblPeriod6S02
        lblTableLinker(Period.PERIOD6, Room.S03) = MasterForm.lblPeriod6S03
        lblTableLinker(Period.PERIOD6, Room.S04) = MasterForm.lblPeriod6S04
        lblTableLinker(Period.PERIOD6, Room.S05) = MasterForm.lblPeriod6S05
        lblTableLinker(Period.PERIOD6, Room.S06) = MasterForm.lblPeriod6S06
        lblTableLinker(Period.PERIOD6, Room.S07) = MasterForm.lblPeriod6S07
        lblTableLinker(Period.PERIOD6, Room.S08) = MasterForm.lblPeriod6S08
        lblTableLinker(Period.PERIOD6, Room.S09) = MasterForm.lblPeriod6S09
        lblTableLinker(Period.PERIOD6, Room.S10) = MasterForm.lblPeriod6S10
    End Sub
End Class
