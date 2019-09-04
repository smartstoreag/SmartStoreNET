﻿using System;
using System.Collections.Generic;
using SmartStore.Collections;
using SmartStore.Core.Domain.ContentSlider;

namespace SmartStore.Services.ContentSlider
{
    /// <summary>
    /// Product service
    /// </summary>
    public partial interface IContentSliderService
    {
        void DeleteContentSlider(SmartStore.Core.Domain.ContentSlider.ContentSlider contentslider);
        IList<SmartStore.Core.Domain.ContentSlider.ContentSlider> GetAllContentSliders();
        SmartStore.Core.Domain.ContentSlider.ContentSlider GetContentSliders(int SliderId);
        IList<Core.Domain.ContentSlider.ContentSlider> GetContentSliderByType(int SliderType);
        IList<Core.Domain.ContentSlider.ContentSlider> GetContentSliderByTypeAndItemId(int SliderType,int ItemId);

        void InsertContentSlider(SmartStore.Core.Domain.ContentSlider.ContentSlider contentslider);

		void UpdateContentSlider(SmartStore.Core.Domain.ContentSlider.ContentSlider contentslider);

        void DeleteContentSliderSlide(Slide contentSliderSlide);

        IList<Slide> GetContentSliderSlidesBySliderId(int contentSliderId);
        IList<Slide> GetContentSliderSlides();

        Slide GetContentSliderSlideById(int slideId);

        void InsertContentSliderSlide(Slide contentSliderSlide);

        void UpdateContentSliderSlide(Slide contentSliderSlide);
    }
}
